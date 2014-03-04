namespace WifiServerProgram
{
    partial class WifiLocator
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
            this.userIdText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.macAddressText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.sendToServerButton = new System.Windows.Forms.Button();
            this.sendReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userIdText
            // 
            this.userIdText.Location = new System.Drawing.Point(32, 24);
            this.userIdText.Name = "userIdText";
            this.userIdText.Size = new System.Drawing.Size(143, 20);
            this.userIdText.TabIndex = 1;
            this.userIdText.Text = "Enter User Id...";
            this.userIdText.Click += new System.EventHandler(this.userIdText_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(32, 135);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(143, 20);
            this.firstNameText.TabIndex = 2;
            this.firstNameText.Text = "Enter User First Name...";
            this.firstNameText.Click += new System.EventHandler(this.firstNameText_Click);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(32, 206);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(143, 20);
            this.emailText.TabIndex = 4;
            this.emailText.Text = "Enter User Email...";
            this.emailText.Click += new System.EventHandler(this.emailText_Click);
            // 
            // macAddressText
            // 
            this.macAddressText.Location = new System.Drawing.Point(32, 97);
            this.macAddressText.Name = "macAddressText";
            this.macAddressText.Size = new System.Drawing.Size(143, 20);
            this.macAddressText.TabIndex = 3;
            this.macAddressText.Text = "Enter User Mac Address...";
            this.macAddressText.Click += new System.EventHandler(this.macAddressText_Click);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(32, 171);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(143, 20);
            this.lastNameText.TabIndex = 6;
            this.lastNameText.Text = "Enter User Last Name...";
            this.lastNameText.Click += new System.EventHandler(this.lastNameText_Click);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(32, 62);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(143, 20);
            this.passwordText.TabIndex = 5;
            this.passwordText.Text = "Enter User Password...";
            this.passwordText.Click += new System.EventHandler(this.passwordText_Click);
            // 
            // sendToServerButton
            // 
            this.sendToServerButton.Location = new System.Drawing.Point(424, 24);
            this.sendToServerButton.Name = "sendToServerButton";
            this.sendToServerButton.Size = new System.Drawing.Size(164, 58);
            this.sendToServerButton.TabIndex = 7;
            this.sendToServerButton.Text = "Send Information";
            this.sendToServerButton.UseVisualStyleBackColor = true;
            this.sendToServerButton.Click += new System.EventHandler(this.sendToServerButton_Click);
            // 
            // sendReport
            // 
            this.sendReport.AutoSize = true;
            this.sendReport.Location = new System.Drawing.Point(29, 254);
            this.sendReport.Name = "sendReport";
            this.sendReport.Size = new System.Drawing.Size(244, 13);
            this.sendReport.TabIndex = 8;
            this.sendReport.Text = "Click Send To Send Information To The Database";
            // 
            // WifiLocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sendReport);
            this.Controls.Add(this.sendToServerButton);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.macAddressText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.userIdText);
            this.Name = "WifiLocator";
            this.Text = "Wifi Locator Control Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIdText;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox macAddressText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button sendToServerButton;
        private System.Windows.Forms.Label sendReport;

    }
}

