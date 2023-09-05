
namespace BrowserAutomation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_startbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_balance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_accountnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_totalaccount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_createdaccount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_startbtn
            // 
            this.m_startbtn.Location = new System.Drawing.Point(213, 107);
            this.m_startbtn.Name = "m_startbtn";
            this.m_startbtn.Size = new System.Drawing.Size(63, 23);
            this.m_startbtn.TabIndex = 0;
            this.m_startbtn.Text = "Start";
            this.m_startbtn.UseVisualStyleBackColor = true;
            this.m_startbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your 2captcha service balance:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_balance
            // 
            this.m_balance.AutoSize = true;
            this.m_balance.Location = new System.Drawing.Point(208, 24);
            this.m_balance.Name = "m_balance";
            this.m_balance.Size = new System.Drawing.Size(0, 15);
            this.m_balance.TabIndex = 2;
            this.m_balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account number:";
            // 
            // m_accountnum
            // 
            this.m_accountnum.Location = new System.Drawing.Point(103, 107);
            this.m_accountnum.Name = "m_accountnum";
            this.m_accountnum.Size = new System.Drawing.Size(90, 23);
            this.m_accountnum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total account:";
            // 
            // m_totalaccount
            // 
            this.m_totalaccount.AutoSize = true;
            this.m_totalaccount.Location = new System.Drawing.Point(100, 63);
            this.m_totalaccount.Name = "m_totalaccount";
            this.m_totalaccount.Size = new System.Drawing.Size(0, 15);
            this.m_totalaccount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Created account";
            // 
            // m_createdaccount
            // 
            this.m_createdaccount.AutoSize = true;
            this.m_createdaccount.Location = new System.Drawing.Point(245, 63);
            this.m_createdaccount.Name = "m_createdaccount";
            this.m_createdaccount.Size = new System.Drawing.Size(0, 15);
            this.m_createdaccount.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_createdaccount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.m_totalaccount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.m_accountnum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.m_balance);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.m_startbtn);
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 146);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Battle.net account creator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 170);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Account Creator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_startbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_balance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m_totalaccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label m_createdaccount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox m_accountnum;
    }
}

