
namespace Clock
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
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
			this.checkBoxShowWeekday = new System.Windows.Forms.CheckBox();
			this.buttonHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ToolStripMenuItemTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemshowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItemshowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemshowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItemchooseFont = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemColors = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItembackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItemforegroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItemloadOnWindowsStartup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripMenuItemexit = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelTime.Location = new System.Drawing.Point(13, 13);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(145, 61);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "Time";
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// checkBoxShowDate
			// 
			this.checkBoxShowDate.AutoSize = true;
			this.checkBoxShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowDate.Location = new System.Drawing.Point(45, 239);
			this.checkBoxShowDate.Name = "checkBoxShowDate";
			this.checkBoxShowDate.Size = new System.Drawing.Size(175, 36);
			this.checkBoxShowDate.TabIndex = 1;
			this.checkBoxShowDate.Text = "Show Date";
			this.checkBoxShowDate.UseVisualStyleBackColor = true;
			// 
			// checkBoxShowWeekday
			// 
			this.checkBoxShowWeekday.AutoSize = true;
			this.checkBoxShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowWeekday.Location = new System.Drawing.Point(45, 269);
			this.checkBoxShowWeekday.Name = "checkBoxShowWeekday";
			this.checkBoxShowWeekday.Size = new System.Drawing.Size(227, 36);
			this.checkBoxShowWeekday.TabIndex = 2;
			this.checkBoxShowWeekday.Text = "Show weekday";
			this.checkBoxShowWeekday.UseVisualStyleBackColor = true;
			// 
			// buttonHideControls
			// 
			this.buttonHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHideControls.Location = new System.Drawing.Point(45, 339);
			this.buttonHideControls.Name = "buttonHideControls";
			this.buttonHideControls.Size = new System.Drawing.Size(227, 45);
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
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTopmost,
            this.ToolStripMenuItemshowControls,
            this.toolStripSeparator2,
            this.ToolStripMenuItemshowDate,
            this.ToolStripMenuItemshowWeekday,
            this.toolStripSeparator1,
            this.ToolStripMenuItemchooseFont,
            this.ToolStripMenuItemColors,
            this.toolStripSeparator3,
            this.ToolStripMenuItemloadOnWindowsStartup,
            this.toolStripSeparator4,
            this.ToolStripMenuItemexit});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(248, 220);
			// 
			// ToolStripMenuItemTopmost
			// 
			this.ToolStripMenuItemTopmost.CheckOnClick = true;
			this.ToolStripMenuItemTopmost.Name = "ToolStripMenuItemTopmost";
			this.ToolStripMenuItemTopmost.Size = new System.Drawing.Size(247, 24);
			this.ToolStripMenuItemTopmost.Text = "Topmost";
			// 
			// ToolStripMenuItemshowControls
			// 
			this.ToolStripMenuItemshowControls.CheckOnClick = true;
			this.ToolStripMenuItemshowControls.Name = "ToolStripMenuItemshowControls";
			this.ToolStripMenuItemshowControls.Size = new System.Drawing.Size(247, 24);
			this.ToolStripMenuItemshowControls.Text = "Show controls";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
			// 
			// ToolStripMenuItemshowDate
			// 
			this.ToolStripMenuItemshowDate.CheckOnClick = true;
			this.ToolStripMenuItemshowDate.Name = "ToolStripMenuItemshowDate";
			this.ToolStripMenuItemshowDate.Size = new System.Drawing.Size(247, 24);
			this.ToolStripMenuItemshowDate.Text = "Show date";
			// 
			// ToolStripMenuItemshowWeekday
			// 
			this.ToolStripMenuItemshowWeekday.CheckOnClick = true;
			this.ToolStripMenuItemshowWeekday.Name = "ToolStripMenuItemshowWeekday";
			this.ToolStripMenuItemshowWeekday.Size = new System.Drawing.Size(247, 24);
			this.ToolStripMenuItemshowWeekday.Text = "Show weekday";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
			// 
			// ToolStripMenuItemchooseFont
			// 
			this.ToolStripMenuItemchooseFont.Name = "ToolStripMenuItemchooseFont";
			this.ToolStripMenuItemchooseFont.Size = new System.Drawing.Size(247, 24);
			this.ToolStripMenuItemchooseFont.Text = "Choose font";
			// 
			// ToolStripMenuItemColors
			// 
			this.ToolStripMenuItemColors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItembackgroundColor,
            this.ToolStripMenuItemforegroundColor});
			this.ToolStripMenuItemColors.Name = "ToolStripMenuItemColors";
			this.ToolStripMenuItemColors.Size = new System.Drawing.Size(247, 24);
			this.ToolStripMenuItemColors.Text = "Colors";
			// 
			// ToolStripMenuItembackgroundColor
			// 
			this.ToolStripMenuItembackgroundColor.Name = "ToolStripMenuItembackgroundColor";
			this.ToolStripMenuItembackgroundColor.Size = new System.Drawing.Size(224, 26);
			this.ToolStripMenuItembackgroundColor.Text = "Background color";
			// 
			// ToolStripMenuItemforegroundColor
			// 
			this.ToolStripMenuItemforegroundColor.Name = "ToolStripMenuItemforegroundColor";
			this.ToolStripMenuItemforegroundColor.Size = new System.Drawing.Size(224, 26);
			this.ToolStripMenuItemforegroundColor.Text = "Foreground color";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(244, 6);
			// 
			// ToolStripMenuItemloadOnWindowsStartup
			// 
			this.ToolStripMenuItemloadOnWindowsStartup.CheckOnClick = true;
			this.ToolStripMenuItemloadOnWindowsStartup.Name = "ToolStripMenuItemloadOnWindowsStartup";
			this.ToolStripMenuItemloadOnWindowsStartup.Size = new System.Drawing.Size(247, 24);
			this.ToolStripMenuItemloadOnWindowsStartup.Text = "Load on Windows startup";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(244, 6);
			// 
			// ToolStripMenuItemexit
			// 
			this.ToolStripMenuItemexit.Name = "ToolStripMenuItemexit";
			this.ToolStripMenuItemexit.Size = new System.Drawing.Size(247, 24);
			this.ToolStripMenuItemexit.Text = "Exit";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 397);
			this.Controls.Add(this.buttonHideControls);
			this.Controls.Add(this.checkBoxShowWeekday);
			this.Controls.Add(this.checkBoxShowDate);
			this.Controls.Add(this.labelTime);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Clock VPD_311";
			this.contextMenuStrip.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTopmost;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemshowControls;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemshowDate;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemshowWeekday;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemchooseFont;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemColors;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItembackgroundColor;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemforegroundColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemloadOnWindowsStartup;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemexit;
	}
}

