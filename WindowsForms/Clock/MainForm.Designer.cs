﻿namespace Clock
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemShowConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemShowDay = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemChooseFont = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemColors = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItemAlarms = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemLoadOnWindowsStartup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
			this.checkBoxShowWeekday = new System.Windows.Forms.CheckBox();
			this.buttonHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(17, 16);
			this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(148, 63);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "Time";
			this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTopmost,
            this.toolStripMenuItemShowControls,
            this.toolStripMenuItemShowConsole,
            this.toolStripSeparator1,
            this.toolStripMenuItemShowDate,
            this.toolStripMenuItemShowDay,
            this.toolStripSeparator2,
            this.toolStripMenuItemChooseFont,
            this.toolStripMenuItemColors,
            this.toolStripSeparator3,
            this.ToolStripMenuItemAlarms,
            this.toolStripSeparator5,
            this.toolStripMenuItemLoadOnWindowsStartup,
            this.toolStripSeparator4,
            this.toolStripMenuItemExit});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(248, 274);
			// 
			// toolStripMenuItemTopmost
			// 
			this.toolStripMenuItemTopmost.CheckOnClick = true;
			this.toolStripMenuItemTopmost.Name = "toolStripMenuItemTopmost";
			this.toolStripMenuItemTopmost.Size = new System.Drawing.Size(247, 24);
			this.toolStripMenuItemTopmost.Text = "Topmost";
			this.toolStripMenuItemTopmost.CheckedChanged += new System.EventHandler(this.toolStripMenuItemTopmost_CheckedChanged);
			// 
			// toolStripMenuItemShowControls
			// 
			this.toolStripMenuItemShowControls.CheckOnClick = true;
			this.toolStripMenuItemShowControls.Name = "toolStripMenuItemShowControls";
			this.toolStripMenuItemShowControls.Size = new System.Drawing.Size(247, 24);
			this.toolStripMenuItemShowControls.Text = "Show controls";
			this.toolStripMenuItemShowControls.CheckStateChanged += new System.EventHandler(this.toolStripMenuItemShowControls_CheckStateChanged);
			// 
			// toolStripMenuItemShowConsole
			// 
			this.toolStripMenuItemShowConsole.CheckOnClick = true;
			this.toolStripMenuItemShowConsole.Name = "toolStripMenuItemShowConsole";
			this.toolStripMenuItemShowConsole.Size = new System.Drawing.Size(247, 24);
			this.toolStripMenuItemShowConsole.Text = "Show console";
			this.toolStripMenuItemShowConsole.CheckedChanged += new System.EventHandler(this.toolStripMenuItemShowConsole_CheckedChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
			// 
			// toolStripMenuItemShowDate
			// 
			this.toolStripMenuItemShowDate.CheckOnClick = true;
			this.toolStripMenuItemShowDate.Name = "toolStripMenuItemShowDate";
			this.toolStripMenuItemShowDate.Size = new System.Drawing.Size(247, 24);
			this.toolStripMenuItemShowDate.Text = "Sow date";
			this.toolStripMenuItemShowDate.CheckedChanged += new System.EventHandler(this.toolStripMenuItemShowDate_CheckedChanged);
			// 
			// toolStripMenuItemShowDay
			// 
			this.toolStripMenuItemShowDay.CheckOnClick = true;
			this.toolStripMenuItemShowDay.Name = "toolStripMenuItemShowDay";
			this.toolStripMenuItemShowDay.Size = new System.Drawing.Size(247, 24);
			this.toolStripMenuItemShowDay.Text = "Show weekday";
			this.toolStripMenuItemShowDay.CheckedChanged += new System.EventHandler(this.toolStripMenuItemShowDay_CheckedChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
			// 
			// toolStripMenuItemChooseFont
			// 
			this.toolStripMenuItemChooseFont.Name = "toolStripMenuItemChooseFont";
			this.toolStripMenuItemChooseFont.Size = new System.Drawing.Size(247, 24);
			this.toolStripMenuItemChooseFont.Text = "Choose font";
			this.toolStripMenuItemChooseFont.Click += new System.EventHandler(this.toolStripMenuItemChooseFont_Click);
			// 
			// toolStripMenuItemColors
			// 
			this.toolStripMenuItemColors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBackgroundColor,
            this.toolStripMenuItemForegroundColor});
			this.toolStripMenuItemColors.Name = "toolStripMenuItemColors";
			this.toolStripMenuItemColors.Size = new System.Drawing.Size(247, 24);
			this.toolStripMenuItemColors.Text = "Colors";
			// 
			// toolStripMenuItemBackgroundColor
			// 
			this.toolStripMenuItemBackgroundColor.Name = "toolStripMenuItemBackgroundColor";
			this.toolStripMenuItemBackgroundColor.Size = new System.Drawing.Size(209, 26);
			this.toolStripMenuItemBackgroundColor.Text = "Background color";
			this.toolStripMenuItemBackgroundColor.Click += new System.EventHandler(this.toolStripMenuItemBackgroundColor_Click);
			// 
			// toolStripMenuItemForegroundColor
			// 
			this.toolStripMenuItemForegroundColor.Name = "toolStripMenuItemForegroundColor";
			this.toolStripMenuItemForegroundColor.Size = new System.Drawing.Size(209, 26);
			this.toolStripMenuItemForegroundColor.Text = "Foreground color";
			this.toolStripMenuItemForegroundColor.Click += new System.EventHandler(this.toolStripMenuItemForegroundColor_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(244, 6);
			// 
			// ToolStripMenuItemAlarms
			// 
			this.ToolStripMenuItemAlarms.Name = "ToolStripMenuItemAlarms";
			this.ToolStripMenuItemAlarms.Size = new System.Drawing.Size(247, 24);
			this.ToolStripMenuItemAlarms.Text = "Alarms";
			this.ToolStripMenuItemAlarms.Click += new System.EventHandler(this.ToolStripMenuItemAlarms_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(244, 6);
			// 
			// toolStripMenuItemLoadOnWindowsStartup
			// 
			this.toolStripMenuItemLoadOnWindowsStartup.CheckOnClick = true;
			this.toolStripMenuItemLoadOnWindowsStartup.Name = "toolStripMenuItemLoadOnWindowsStartup";
			this.toolStripMenuItemLoadOnWindowsStartup.Size = new System.Drawing.Size(247, 24);
			this.toolStripMenuItemLoadOnWindowsStartup.Text = "Load on Windows startup";
			this.toolStripMenuItemLoadOnWindowsStartup.CheckedChanged += new System.EventHandler(this.toolStripMenuItemLoadOnWindowsStartup_CheckedChanged);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(244, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(247, 24);
			this.toolStripMenuItemExit.Text = "Exit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// checkBoxShowDate
			// 
			this.checkBoxShowDate.AutoSize = true;
			this.checkBoxShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowDate.Location = new System.Drawing.Point(13, 139);
			this.checkBoxShowDate.Margin = new System.Windows.Forms.Padding(4);
			this.checkBoxShowDate.Name = "checkBoxShowDate";
			this.checkBoxShowDate.Size = new System.Drawing.Size(164, 35);
			this.checkBoxShowDate.TabIndex = 1;
			this.checkBoxShowDate.Text = "Show date";
			this.checkBoxShowDate.UseVisualStyleBackColor = true;
			this.checkBoxShowDate.CheckedChanged += new System.EventHandler(this.checkBoxShowDate_CheckedChanged);
			// 
			// checkBoxShowWeekday
			// 
			this.checkBoxShowWeekday.AutoSize = true;
			this.checkBoxShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowWeekday.Location = new System.Drawing.Point(13, 182);
			this.checkBoxShowWeekday.Margin = new System.Windows.Forms.Padding(4);
			this.checkBoxShowWeekday.Name = "checkBoxShowWeekday";
			this.checkBoxShowWeekday.Size = new System.Drawing.Size(219, 35);
			this.checkBoxShowWeekday.TabIndex = 2;
			this.checkBoxShowWeekday.Text = "Show weekday";
			this.checkBoxShowWeekday.UseVisualStyleBackColor = true;
			this.checkBoxShowWeekday.CheckedChanged += new System.EventHandler(this.checkBoxShowWeekday_CheckedChanged);
			// 
			// buttonHideControls
			// 
			this.buttonHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHideControls.Location = new System.Drawing.Point(13, 236);
			this.buttonHideControls.Margin = new System.Windows.Forms.Padding(4);
			this.buttonHideControls.Name = "buttonHideControls";
			this.buttonHideControls.Size = new System.Drawing.Size(233, 65);
			this.buttonHideControls.TabIndex = 3;
			this.buttonHideControls.Text = "Hide controls";
			this.buttonHideControls.UseVisualStyleBackColor = true;
			this.buttonHideControls.Click += new System.EventHandler(this.buttonHideControls_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "notifyIcon";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 324);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(358, 55);
			this.axWindowsMediaPlayer1.TabIndex = 4;
			this.axWindowsMediaPlayer1.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 425);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.Controls.Add(this.buttonHideControls);
			this.Controls.Add(this.checkBoxShowWeekday);
			this.Controls.Add(this.checkBoxShowDate);
			this.Controls.Add(this.labelTime);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Clock VPD_311";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox checkBoxShowDate;
		private System.Windows.Forms.CheckBox checkBoxShowWeekday;
		private System.Windows.Forms.Button buttonHideControls;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTopmost;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowControls;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowDate;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowDay;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChooseFont;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColors;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBackgroundColor;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForegroundColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadOnWindowsStartup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowConsole;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAlarms;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
	}
}

