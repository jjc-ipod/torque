namespace TorControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabWindow = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.lblSummary_port = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSummary_ip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSummary_status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCircuits = new System.Windows.Forms.TabPage();
            this.tabCircuits_Interior = new System.Windows.Forms.TabControl();
            this.tabCircuits_Global = new System.Windows.Forms.TabPage();
            this.btnRefreshRelays = new System.Windows.Forms.Button();
            this.lvGlobal = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colActive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFlags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCircuits_Connected = new System.Windows.Forms.TabPage();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.btnConsoleSend = new System.Windows.Forms.Button();
            this.txtConsoleCommand = new System.Windows.Forms.TextBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.networkConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIdentityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panLoading = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabWindow.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabCircuits.SuspendLayout();
            this.tabCircuits_Interior.SuspendLayout();
            this.tabCircuits_Global.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabWindow
            // 
            this.tabWindow.Controls.Add(this.tabMain);
            this.tabWindow.Controls.Add(this.tabCircuits);
            this.tabWindow.Controls.Add(this.tabConsole);
            this.tabWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWindow.Location = new System.Drawing.Point(0, 24);
            this.tabWindow.Name = "tabWindow";
            this.tabWindow.SelectedIndex = 0;
            this.tabWindow.Size = new System.Drawing.Size(774, 480);
            this.tabWindow.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.lblSummary_port);
            this.tabMain.Controls.Add(this.label3);
            this.tabMain.Controls.Add(this.lblSummary_ip);
            this.tabMain.Controls.Add(this.label2);
            this.tabMain.Controls.Add(this.lblSummary_status);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(766, 454);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Summary";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // lblSummary_port
            // 
            this.lblSummary_port.AutoSize = true;
            this.lblSummary_port.Location = new System.Drawing.Point(123, 97);
            this.lblSummary_port.Name = "lblSummary_port";
            this.lblSummary_port.Size = new System.Drawing.Size(31, 13);
            this.lblSummary_port.TabIndex = 5;
            this.lblSummary_port.Text = "9051";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CTRL Port:";
            // 
            // lblSummary_ip
            // 
            this.lblSummary_ip.AutoSize = true;
            this.lblSummary_ip.Location = new System.Drawing.Point(123, 84);
            this.lblSummary_ip.Name = "lblSummary_ip";
            this.lblSummary_ip.Size = new System.Drawing.Size(52, 13);
            this.lblSummary_ip.TabIndex = 3;
            this.lblSummary_ip.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client IP:";
            // 
            // lblSummary_status
            // 
            this.lblSummary_status.AutoSize = true;
            this.lblSummary_status.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary_status.ForeColor = System.Drawing.Color.Red;
            this.lblSummary_status.Location = new System.Drawing.Point(3, 3);
            this.lblSummary_status.Name = "lblSummary_status";
            this.lblSummary_status.Size = new System.Drawing.Size(136, 25);
            this.lblSummary_status.TabIndex = 1;
            this.lblSummary_status.Text = "Not connected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // tabCircuits
            // 
            this.tabCircuits.Controls.Add(this.tabCircuits_Interior);
            this.tabCircuits.Location = new System.Drawing.Point(4, 22);
            this.tabCircuits.Name = "tabCircuits";
            this.tabCircuits.Padding = new System.Windows.Forms.Padding(3);
            this.tabCircuits.Size = new System.Drawing.Size(766, 454);
            this.tabCircuits.TabIndex = 1;
            this.tabCircuits.Text = "Circuits";
            this.tabCircuits.UseVisualStyleBackColor = true;
            // 
            // tabCircuits_Interior
            // 
            this.tabCircuits_Interior.Controls.Add(this.tabCircuits_Global);
            this.tabCircuits_Interior.Controls.Add(this.tabCircuits_Connected);
            this.tabCircuits_Interior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCircuits_Interior.Location = new System.Drawing.Point(3, 3);
            this.tabCircuits_Interior.Name = "tabCircuits_Interior";
            this.tabCircuits_Interior.SelectedIndex = 0;
            this.tabCircuits_Interior.Size = new System.Drawing.Size(760, 448);
            this.tabCircuits_Interior.TabIndex = 0;
            // 
            // tabCircuits_Global
            // 
            this.tabCircuits_Global.Controls.Add(this.panLoading);
            this.tabCircuits_Global.Controls.Add(this.btnRefreshRelays);
            this.tabCircuits_Global.Controls.Add(this.lvGlobal);
            this.tabCircuits_Global.Location = new System.Drawing.Point(4, 22);
            this.tabCircuits_Global.Name = "tabCircuits_Global";
            this.tabCircuits_Global.Padding = new System.Windows.Forms.Padding(3);
            this.tabCircuits_Global.Size = new System.Drawing.Size(752, 422);
            this.tabCircuits_Global.TabIndex = 0;
            this.tabCircuits_Global.Text = "Global";
            this.tabCircuits_Global.UseVisualStyleBackColor = true;
            // 
            // btnRefreshRelays
            // 
            this.btnRefreshRelays.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefreshRelays.Location = new System.Drawing.Point(3, 396);
            this.btnRefreshRelays.Name = "btnRefreshRelays";
            this.btnRefreshRelays.Size = new System.Drawing.Size(746, 23);
            this.btnRefreshRelays.TabIndex = 1;
            this.btnRefreshRelays.Text = "Refresh Relays";
            this.btnRefreshRelays.UseVisualStyleBackColor = true;
            this.btnRefreshRelays.Click += new System.EventHandler(this.btnRefreshRelays_Click);
            // 
            // lvGlobal
            // 
            this.lvGlobal.AllowColumnReorder = true;
            this.lvGlobal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colAddress,
            this.colSpeed,
            this.colActive,
            this.colVersion,
            this.colFlags});
            this.lvGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGlobal.FullRowSelect = true;
            this.lvGlobal.GridLines = true;
            this.lvGlobal.Location = new System.Drawing.Point(3, 3);
            this.lvGlobal.MultiSelect = false;
            this.lvGlobal.Name = "lvGlobal";
            this.lvGlobal.Size = new System.Drawing.Size(746, 416);
            this.lvGlobal.TabIndex = 0;
            this.lvGlobal.UseCompatibleStateImageBehavior = false;
            this.lvGlobal.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 102;
            // 
            // colActive
            // 
            this.colActive.Text = "Active since";
            this.colActive.Width = 89;
            // 
            // colSpeed
            // 
            this.colSpeed.Text = "Speed (KB/s)";
            this.colSpeed.Width = 80;
            // 
            // colVersion
            // 
            this.colVersion.Text = "TOR Version";
            this.colVersion.Width = 76;
            // 
            // colFlags
            // 
            this.colFlags.Text = "Flags";
            // 
            // tabCircuits_Connected
            // 
            this.tabCircuits_Connected.Location = new System.Drawing.Point(4, 22);
            this.tabCircuits_Connected.Name = "tabCircuits_Connected";
            this.tabCircuits_Connected.Padding = new System.Windows.Forms.Padding(3);
            this.tabCircuits_Connected.Size = new System.Drawing.Size(752, 422);
            this.tabCircuits_Connected.TabIndex = 1;
            this.tabCircuits_Connected.Text = "Connected";
            this.tabCircuits_Connected.UseVisualStyleBackColor = true;
            // 
            // tabConsole
            // 
            this.tabConsole.Controls.Add(this.btnConsoleSend);
            this.tabConsole.Controls.Add(this.txtConsoleCommand);
            this.tabConsole.Controls.Add(this.txtConsole);
            this.tabConsole.Location = new System.Drawing.Point(4, 22);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsole.Size = new System.Drawing.Size(766, 454);
            this.tabConsole.TabIndex = 2;
            this.tabConsole.Text = "Console";
            this.tabConsole.UseVisualStyleBackColor = true;
            // 
            // btnConsoleSend
            // 
            this.btnConsoleSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConsoleSend.Location = new System.Drawing.Point(688, 431);
            this.btnConsoleSend.Name = "btnConsoleSend";
            this.btnConsoleSend.Size = new System.Drawing.Size(75, 20);
            this.btnConsoleSend.TabIndex = 2;
            this.btnConsoleSend.Text = "SEND";
            this.btnConsoleSend.UseVisualStyleBackColor = true;
            this.btnConsoleSend.Click += new System.EventHandler(this.btnConsoleSend_Click);
            // 
            // txtConsoleCommand
            // 
            this.txtConsoleCommand.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtConsoleCommand.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsoleCommand.Location = new System.Drawing.Point(3, 431);
            this.txtConsoleCommand.Name = "txtConsoleCommand";
            this.txtConsoleCommand.Size = new System.Drawing.Size(679, 20);
            this.txtConsoleCommand.TabIndex = 1;
            this.txtConsoleCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsoleCommand_KeyPress);
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.Color.Black;
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtConsole.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.Color.Lime;
            this.txtConsole.Location = new System.Drawing.Point(3, 3);
            this.txtConsole.MaxLength = 2147483647;
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(760, 428);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = resources.GetString("txtConsole.Text");
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.connectivityToolStripMenuItem,
            this.torToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // connectivityToolStripMenuItem
            // 
            this.connectivityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.networkConfigToolStripMenuItem});
            this.connectivityToolStripMenuItem.Name = "connectivityToolStripMenuItem";
            this.connectivityToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.connectivityToolStripMenuItem.Text = "Connectivity";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Enabled = false;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // networkConfigToolStripMenuItem
            // 
            this.networkConfigToolStripMenuItem.Name = "networkConfigToolStripMenuItem";
            this.networkConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.networkConfigToolStripMenuItem.Text = "Settings...";
            this.networkConfigToolStripMenuItem.Click += new System.EventHandler(this.networkConfigToolStripMenuItem_Click);
            // 
            // torToolStripMenuItem
            // 
            this.torToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newIdentityToolStripMenuItem});
            this.torToolStripMenuItem.Enabled = false;
            this.torToolStripMenuItem.Name = "torToolStripMenuItem";
            this.torToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.torToolStripMenuItem.Text = "Tor";
            // 
            // newIdentityToolStripMenuItem
            // 
            this.newIdentityToolStripMenuItem.Name = "newIdentityToolStripMenuItem";
            this.newIdentityToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.newIdentityToolStripMenuItem.Text = "New Identity";
            this.newIdentityToolStripMenuItem.Click += new System.EventHandler(this.newIdentityToolStripMenuItem_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 200;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // colAddress
            // 
            this.colAddress.Text = "IP Address";
            this.colAddress.Width = 94;
            // 
            // panLoading
            // 
            this.panLoading.BackColor = System.Drawing.SystemColors.Control;
            this.panLoading.Controls.Add(this.progressBar1);
            this.panLoading.Controls.Add(this.label4);
            this.panLoading.Location = new System.Drawing.Point(259, 130);
            this.panLoading.Name = "panLoading";
            this.panLoading.Size = new System.Drawing.Size(200, 100);
            this.panLoading.TabIndex = 2;
            this.panLoading.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loading Relays...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 53);
            this.progressBar1.MarqueeAnimationSpeed = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 13);
            this.progressBar1.Step = 20;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 504);
            this.Controls.Add(this.tabWindow);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Torque";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabWindow.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabCircuits.ResumeLayout(false);
            this.tabCircuits_Interior.ResumeLayout(false);
            this.tabCircuits_Global.ResumeLayout(false);
            this.tabConsole.ResumeLayout(false);
            this.tabConsole.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panLoading.ResumeLayout(false);
            this.panLoading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabWindow;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabCircuits;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem networkConfigToolStripMenuItem;
        private System.Windows.Forms.TabPage tabConsole;
        private System.Windows.Forms.Button btnConsoleSend;
        private System.Windows.Forms.TextBox txtConsoleCommand;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label lblSummary_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSummary_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSummary_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.TabControl tabCircuits_Interior;
        private System.Windows.Forms.TabPage tabCircuits_Global;
        private System.Windows.Forms.ListView lvGlobal;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colActive;
        private System.Windows.Forms.ColumnHeader colSpeed;
        private System.Windows.Forms.ColumnHeader colVersion;
        private System.Windows.Forms.ColumnHeader colFlags;
        private System.Windows.Forms.TabPage tabCircuits_Connected;
        private System.Windows.Forms.Button btnRefreshRelays;
        private System.Windows.Forms.ToolStripMenuItem torToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newIdentityToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.Panel panLoading;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
    }
}

