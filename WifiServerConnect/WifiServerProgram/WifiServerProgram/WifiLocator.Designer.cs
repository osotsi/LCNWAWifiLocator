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
            this.accessPointName = new System.Windows.Forms.TextBox();
            this.signalStrength = new System.Windows.Forms.TextBox();
            this.ssid = new System.Windows.Forms.TextBox();
            this.sendLocationInformation = new System.Windows.Forms.Button();
            this.locationInfoLabel = new System.Windows.Forms.Label();
            this.accessPointMacAddress = new System.Windows.Forms.TextBox();
            this.connectedDevicesText = new System.Windows.Forms.Label();
            this.clientList = new System.Windows.Forms.ListBox();
            this.listenButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.sendToServerButton.Location = new System.Drawing.Point(269, 24);
            this.sendToServerButton.Name = "sendToServerButton";
            this.sendToServerButton.Size = new System.Drawing.Size(164, 58);
            this.sendToServerButton.TabIndex = 7;
            this.sendToServerButton.Text = "Send User Information";
            this.sendToServerButton.UseVisualStyleBackColor = true;
            this.sendToServerButton.Click += new System.EventHandler(this.sendToServerButton_Click);
            // 
            // sendReport
            // 
            this.sendReport.AutoSize = true;
            this.sendReport.Location = new System.Drawing.Point(29, 254);
            this.sendReport.Name = "sendReport";
            this.sendReport.Size = new System.Drawing.Size(269, 13);
            this.sendReport.TabIndex = 8;
            this.sendReport.Text = "Click Send To Send User Information To The Database";
            // 
            // accessPointName
            // 
            this.accessPointName.Location = new System.Drawing.Point(32, 292);
            this.accessPointName.Name = "accessPointName";
            this.accessPointName.Size = new System.Drawing.Size(185, 20);
            this.accessPointName.TabIndex = 9;
            this.accessPointName.Text = "Enter Access Point Name...";
            this.accessPointName.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // signalStrength
            // 
            this.signalStrength.Location = new System.Drawing.Point(32, 318);
            this.signalStrength.Name = "signalStrength";
            this.signalStrength.Size = new System.Drawing.Size(185, 20);
            this.signalStrength.TabIndex = 10;
            this.signalStrength.Text = "Enter Signal Strength...";
            this.signalStrength.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // ssid
            // 
            this.ssid.Location = new System.Drawing.Point(32, 344);
            this.ssid.Name = "ssid";
            this.ssid.Size = new System.Drawing.Size(185, 20);
            this.ssid.TabIndex = 11;
            this.ssid.Text = "Enter SSID...";
            this.ssid.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // sendLocationInformation
            // 
            this.sendLocationInformation.Location = new System.Drawing.Point(269, 292);
            this.sendLocationInformation.Name = "sendLocationInformation";
            this.sendLocationInformation.Size = new System.Drawing.Size(164, 46);
            this.sendLocationInformation.TabIndex = 12;
            this.sendLocationInformation.Text = "Send Location Information";
            this.sendLocationInformation.UseVisualStyleBackColor = true;
            this.sendLocationInformation.Click += new System.EventHandler(this.button1_Click);
            // 
            // locationInfoLabel
            // 
            this.locationInfoLabel.AutoSize = true;
            this.locationInfoLabel.Location = new System.Drawing.Point(29, 428);
            this.locationInfoLabel.Name = "locationInfoLabel";
            this.locationInfoLabel.Size = new System.Drawing.Size(288, 13);
            this.locationInfoLabel.TabIndex = 13;
            this.locationInfoLabel.Text = "Click Send To Send Location Information To The Database";
            // 
            // accessPointMacAddress
            // 
            this.accessPointMacAddress.Location = new System.Drawing.Point(32, 371);
            this.accessPointMacAddress.Name = "accessPointMacAddress";
            this.accessPointMacAddress.Size = new System.Drawing.Size(185, 20);
            this.accessPointMacAddress.TabIndex = 14;
            this.accessPointMacAddress.Text = "Enter Access Point Mac Address...";
            this.accessPointMacAddress.Click += new System.EventHandler(this.accessPointMacAddress_Click);
            // 
            // connectedDevicesText
            // 
            this.connectedDevicesText.AutoSize = true;
            this.connectedDevicesText.Location = new System.Drawing.Point(451, 24);
            this.connectedDevicesText.Name = "connectedDevicesText";
            this.connectedDevicesText.Size = new System.Drawing.Size(104, 13);
            this.connectedDevicesText.TabIndex = 15;
            this.connectedDevicesText.Text = "Connected Devices:";
            // 
            // clientList
            // 
            this.clientList.FormattingEnabled = true;
            this.clientList.Location = new System.Drawing.Point(454, 41);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(120, 95);
            this.clientList.TabIndex = 16;
            // 
            // listenButton
            // 
            this.listenButton.Location = new System.Drawing.Point(454, 171);
            this.listenButton.Name = "listenButton";
            this.listenButton.Size = new System.Drawing.Size(120, 55);
            this.listenButton.TabIndex = 17;
            this.listenButton.Text = "Start Listening...";
            this.listenButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commandsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // quitButton
            // 
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(152, 22);
            this.quitButton.Text = "Quit";
            this.quitButton.Click += new System.EventHandler(this.quitButton_click);
            // 
            // WifiLocator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.listenButton);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.connectedDevicesText);
            this.Controls.Add(this.accessPointMacAddress);
            this.Controls.Add(this.locationInfoLabel);
            this.Controls.Add(this.sendLocationInformation);
            this.Controls.Add(this.ssid);
            this.Controls.Add(this.signalStrength);
            this.Controls.Add(this.accessPointName);
            this.Controls.Add(this.sendReport);
            this.Controls.Add(this.sendToServerButton);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.macAddressText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WifiLocator";
            this.Text = "Wifi Locator Server Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //Test #5
        public System.Windows.Forms.TextBox userIdText;
        public System.Windows.Forms.TextBox firstNameText;
        public System.Windows.Forms.TextBox emailText;
        public System.Windows.Forms.TextBox macAddressText;
        public System.Windows.Forms.TextBox lastNameText;
        public System.Windows.Forms.TextBox passwordText;
        //Test #3
        public System.Windows.Forms.Button sendToServerButton;

        public System.Windows.Forms.Label sendReport;

        //Test #7
        private System.Windows.Forms.TextBox accessPointName;
        private System.Windows.Forms.TextBox signalStrength;
        private System.Windows.Forms.TextBox ssid;
        private System.Windows.Forms.Button sendLocationInformation;
        private System.Windows.Forms.Label locationInfoLabel;
        private System.Windows.Forms.TextBox accessPointMacAddress;
        private System.Windows.Forms.Label connectedDevicesText;
        private System.Windows.Forms.ListBox clientList;
        private System.Windows.Forms.Button listenButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitButton;

    }
}

