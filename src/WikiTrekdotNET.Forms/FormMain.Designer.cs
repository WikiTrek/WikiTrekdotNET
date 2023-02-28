namespace WikiTrekdotNET.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNTest = new System.Windows.Forms.Button();
            this.TXTUser = new System.Windows.Forms.TextBox();
            this.TXTPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNTest
            // 
            this.BTNTest.Location = new System.Drawing.Point(857, 588);
            this.BTNTest.Name = "BTNTest";
            this.BTNTest.Size = new System.Drawing.Size(75, 23);
            this.BTNTest.TabIndex = 0;
            this.BTNTest.Text = "Test";
            this.BTNTest.UseVisualStyleBackColor = true;
            this.BTNTest.Click += new System.EventHandler(this.BTNTest_Click);
            // 
            // TXTUser
            // 
            this.TXTUser.Location = new System.Drawing.Point(832, 536);
            this.TXTUser.Name = "TXTUser";
            this.TXTUser.Size = new System.Drawing.Size(100, 20);
            this.TXTUser.TabIndex = 1;
            // 
            // TXTPassword
            // 
            this.TXTPassword.Location = new System.Drawing.Point(832, 562);
            this.TXTPassword.Name = "TXTPassword";
            this.TXTPassword.PasswordChar = '*';
            this.TXTPassword.Size = new System.Drawing.Size(100, 20);
            this.TXTPassword.TabIndex = 2;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(944, 707);
            this.Controls.Add(this.TXTPassword);
            this.Controls.Add(this.TXTUser);
            this.Controls.Add(this.BTNTest);
            this.Name = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button BTNTest;
        private System.Windows.Forms.TextBox TXTUser;
        private System.Windows.Forms.TextBox TXTPassword;
    }
}

