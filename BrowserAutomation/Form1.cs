using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserAutomation
{
    public partial class Form1 : Form
    {
        public static int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_accountnum.Text == "")
                MessageBox.Show("Please input account number");
            else
            {
                m_startbtn.Enabled = false;
                m_totalaccount.Text = m_accountnum.Text;
                int n = 0;
                while (n < int.Parse(m_accountnum.Text))
                {
                    _ = getbalance();
                    _ = bnetFlow.bnet();
                    n++;
                    m_createdaccount.Text = counter.ToString();
                }
                m_startbtn.Enabled = true;
            }  
        }

        public async Task getbalance()
        {
            TwoCaptcha.TwoCaptcha solver = new TwoCaptcha.TwoCaptcha("abe8421ee41d9384227390a98d9b3353");
            //get balance
            double dbalance = await solver.Balance();
            m_balance.Text = dbalance.ToString();
        }



    }
}
