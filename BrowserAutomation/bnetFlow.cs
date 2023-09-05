using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using SeleniumUndetectedChromeDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoCaptcha.Captcha;

namespace BrowserAutomation
{
    class bnetFlow
    {
        public static async Task bnet()
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"--load-extension=D:\Net_tools\Extension\2captcha-solver-main");
            var driverExecutablePath = $@"C:\Users\Vigil Light\.cache\selenium\chromedriver\win32\107.0.5304.62\chromedriver.exe";

            dynamic userData = JObject.Parse(utils.getUserData());
            Random rnd = new Random();
            string[] mailDomains = { "@gmail.com", "@hotmail.com", "@live.com", "@yahoo.com", "@outlook.com", "@msn.com" };
            string username = Convert.ToString(userData.first_name).Substring(0, 3) + Convert.ToString(userData.last_name).Substring(0, 3) + (rnd.Next(0, 5000));
            string email = ($"{username}{mailDomains[rnd.Next(0, 5)]}");

            //setup proxy driver
            /*var options = new ChromeOptions();
            var proxy = new Proxy();
            proxy.SocksProxy = "203.166.143.40:12324";
            proxy.SocksUserName = "14af4eea83e58";
            proxy.SocksPassword = "7501ef7a78";
            options.Proxy = proxy;
            */

            using var driver = UndetectedChromeDriver.Create(
                options:options,
                driverExecutablePath: driverExecutablePath);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            try
            {
                driver.Navigate().GoToUrl("https://account.battle.net/creation/flow/creation-full");
            }
            
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //driver.Manage().Window.Size = new System.Drawing.Size(1936, 1066);
            var randstringBuilder = new StringBuilder();
            ext.WaitUntilVisible(driver, By.Id("capture-country")).SendKeys(randstringBuilder.Append(RandomString(4,true)).ToString());
            {
                var element = driver.FindElement(By.Name("dob-plain"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.Id("dob-field-active"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            driver.FindElement(By.Id("flow-form")).Click();
            driver.FindElement(By.Name("dob-month")).SendKeys($"{ rnd.Next(1, 12)}");
            driver.FindElement(By.Name("dob-day")).SendKeys($"{rnd.Next(1, 28)}");
            driver.FindElement(By.Name("dob-year")).SendKeys($"{rnd.Next(1989, 2003)}");
            driver.FindElement(By.Id("flow-form-submit-btn")).Click();

            //Wait element
            ext.WaitUntilVisible(driver, By.Id("capture-first-name")).Click();
            driver.FindElement(By.Id("capture-first-name")).SendKeys($"{Convert.ToString(userData.first_name)}");
            driver.FindElement(By.Id("capture-last-name")).SendKeys($"{Convert.ToString(userData.last_name)}");
            driver.FindElement(By.Id("flow-form-submit-btn")).Click();
            //Wait element
            ext.WaitUntilVisible(driver, By.Id("capture-email")).Click();
            driver.FindElement(By.Id("capture-email")).SendKeys(email.ToLower());
            driver.FindElement(By.Id("flow-form-submit-btn")).Click();
            //Wait element
            
            {
                var element = ext.WaitUntilVisible(driver, By.Id("legal-checkboxes"));
                Actions builder = new Actions(driver);
                try
                {
                    builder.MoveToElement(element).MoveByOffset(-200, 0).Click().Perform();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            driver.FindElement(By.Id("flow-form-submit-btn")).Click();
            {
                var element = driver.FindElement(By.Id("flow-form-submit-btn"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }

            //Wait element
            ext.WaitUntilVisible(driver, By.Id("capture-password")).Click();
            driver.FindElement(By.Id("capture-password")).SendKeys($"{Convert.ToString(userData.password)}");
            driver.FindElement(By.Id("flow-form-submit-btn")).Click();
            //Wait element
            ext.WaitUntilVisible(driver, By.Id("capture-battletag")).Click();
            driver.FindElement(By.Id("capture-battletag")).Click();
            {
                var element = driver.FindElement(By.Id("capture-battletag"));
                Actions builder = new Actions(driver);
                builder.DoubleClick(element).Perform();
            }
            driver.FindElement(By.Id("capture-battletag")).SendKeys(username);
            driver.FindElement(By.Id("flow-form-submit-btn")).Click();

            try
            {
                await Task.Delay(10000);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().Frame(ext.WaitUntilVisible(driver, By.XPath("/html/body/div[4]/iframe")));
            driver.FindElement(By.XPath("//*[@id=\"challenge\"]/div[2]")).Click();
            driver.SwitchTo().DefaultContent();
            if (ext.WaitUntilVisible(driver, By.Id("flow-cta-btn")) != null)
                Console.WriteLine("finished");
            MessageBox.Show("Account was created!");
            //driver.SwitchTo().DefaultContent();
            //driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[4]/iframe")));
            //string token = @$"14637d74d13a1043.4768186104|r=ap-southeast-1|mainbgclr=%23002553|metabgclr=%23002553|guitextcolor=%23006FB2|maintxtclr=%23ffffff|metaiconclr=%23FFFFFF|meta=7|pk=E8A75615-1CBA-5DFF-8032-D16BCF234E10|at=40|rid=54|ag=101|cdn_url=https%3A%2F%2Fblizzard-api.arkoselabs.com%2Fcdn%2Ffc|lurl=https%3A%2F%2Faudio-ap-southeast-1.arkoselabs.com|surl=https%3A%2F%2Fblizzard-api.arkoselabs.com|smurl=https%3A%2F%2Fblizzard-api.arkoselabs.com%2Fcdn%2Ffc%2Fassets%2Fstyle-manager";
            //js.ExecuteScript("arguments[0].value = '" + token + "';", driver.FindElement(By.Id("verification-token")));
            //js.ExecuteScript("arguments[0].value = '" + token + "';", driver.FindElement(By.Id("FunCaptcha-Token")));

            //driver.SwitchTo().DefaultContent();
            //driver.SwitchTo().Frame(driver.FindElement(By.XPath("/html/body/div[4]/iframe")));
            //js.ExecuteScript("parent.postMessage(JSON.stringify({eventId: \"challenge-complete\",payload: {sessionToken: \"" + token + "\"}}), \"*\")");
            driver.Close();
            Form1.counter++;
        }
        public static string RandomString(int size, bool lowerCase = false)
        {
            Random _random = new Random();
            var builder = new StringBuilder(size);
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  
            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }
            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }
    }
}
