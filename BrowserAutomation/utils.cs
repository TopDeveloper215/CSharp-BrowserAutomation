using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BrowserAutomation
{
    class utils
    {

        private static string Get(string url, string endpoint = "")
        {
            WebRequest request = WebRequest.Create($"{url}{endpoint}");
            request.Method = "GET";

            WebResponse response = request.GetResponse();

            string responseFromServer;
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream ?? throw new InvalidOperationException());
                responseFromServer = reader.ReadToEnd();
            }
            response.Close();

            //Console.WriteLine(responseFromServer);
            return responseFromServer;

        }

        public static string getUserData()
        {
            return Get("https://random-data-api.com/api/v2/users");
        }

    }

    static class ext
    {
        public static IWebElement WaitUntilVisible(
                   this IWebDriver driver,
                   By itemSpecifier,
                   int secondsTimeout = 60)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, secondsTimeout));
            var element = wait.Until<IWebElement>(driver =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(itemSpecifier);
                    if (elementToBeDisplayed.Displayed)
                    {
                        return elementToBeDisplayed;
                    }
                    return null;
                }
                catch (Exception)
                {
                    return null;
                }
            });
            return element;
        }
    }
}
