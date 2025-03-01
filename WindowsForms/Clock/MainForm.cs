﻿

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   
using System.IO;
using Microsoft.Win32;

namespace Clock
{
	public partial class MainForm : Form
	{
		

FontDialog fontDialog;
		AlarmsForm alarmsForm;
		Alarm nextAlarm;
		public MainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.AliceBlue;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			//toolStripMenuItemShowControls.Checked = false;	//Works not correctly
			toolStripMenuItemShowControls.Checked = true;
			toolStripMenuItemShowConsole.Checked = true;

			//fontDialog = new FontDialog();
			Console.WriteLine(Directory.GetCurrentDirectory());
			LoadSettings();
			alarmsForm = new AlarmsForm(this);
			if (fontDialog == null) fontDialog = new FontDialog();
			axWindowsMediaPlayer1.Visible = false;
		}

		void SetVisibility(bool visible)
		{
			checkBoxShowDate.Visible = visible;
			checkBoxShowWeekday.Visible = visible;
			buttonHideControls.Visible = visible;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedDialog : FormBorderStyle.None;
			this.ShowInTaskbar = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
		}
		void LoadSettings()
		{
			StreamReader sr = null;
			try
			{
				sr = new StreamReader($"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\Settings.ini");
				toolStripMenuItemTopmost.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowControls.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowConsole.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowDate.Checked = Boolean.Parse(sr.ReadLine());
				toolStripMenuItemShowDay.Checked = Boolean.Parse(sr.ReadLine());
				string fontname = sr.ReadLine();
				float fontsize = (float)Convert.ToDouble(sr.ReadLine());
				labelTime.BackColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
				labelTime.ForeColor = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
				sr.Close();
				fontDialog = new FontDialog(fontname, fontsize);
				labelTime.Font = fontDialog.Font;
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "In LoadSettings()", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(this, ex.ToString(), "In LoadSettings()", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void SaveSettings()
		{
			StreamWriter sw =
				new StreamWriter($"{Path.GetDirectoryName(Application.ExecutablePath)}\\..\\..\\Settings.ini");
			sw.WriteLine($"{toolStripMenuItemTopmost.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowControls.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowConsole.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowDate.Checked}");
			sw.WriteLine($"{toolStripMenuItemShowDay.Checked}");
			sw.WriteLine($"{fontDialog.FontFilename}");
			sw.WriteLine($"{labelTime.Font.Size}");
			sw.WriteLine($"{labelTime.BackColor.ToArgb()}");
			sw.WriteLine($"{labelTime.ForeColor.ToArgb()}");
			sw.Close();
		}
		Alarm FindNextAlarm()
		{
			nextAlarm = alarmsForm.Alarms.Items.Cast<Alarm>().ToArray().Min();
			return nextAlarm;
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			//Обработчик события - это самая обычная функция, которая неявно вызывается 
			//					   при возникновении определенного события.
			//У элемента интерфкйса может быть множество событий, и одно из них будет событием по умолчанию.
			labelTime.Text = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
			//labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
			if (checkBoxShowDate.Checked)
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			if (checkBoxShowWeekday.Checked)
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			notifyIcon.Text =
				$"{DateTime.Now.ToString("hh:mm tt")}\n" +
				$"{DateTime.Now.ToString("yyyy.MM.dd")}\n" +
				$"{DateTime.Now.DayOfWeek}";

			nextAlarm = FindNextAlarm();
			if (nextAlarm != null)Console.WriteLine(nextAlarm);
				if(
				nextAlarm != null&&
				nextAlarm.Time.Hours == DateTime.Now.Hour&&
				nextAlarm.Time.Minutes == DateTime.Now.Minute&&
				nextAlarm.Time.Seconds == DateTime.Now.Second
				)
			{
				System.Threading.Thread.Sleep(1000);
				axWindowsMediaPlayer1.Visible = true;
				axWindowsMediaPlayer1.URL = nextAlarm.Filename;
				axWindowsMediaPlayer1.settings.volume = 100;
				axWindowsMediaPlayer1.Ctlcontrols.play();			
					if(nextAlarm.Message!="")
	MessageBox.Show(this, nextAlarm.ToString(), "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
			}
			
		}

		private void buttonHideControls_Click(object sender, EventArgs e)
		{
			//SetVisibility(false);
			toolStripMenuItemShowControls.Checked = false;
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			//SetVisibility(true);
			toolStripMenuItemShowControls.Checked = true;
		}

		private void toolStripMenuItemExit_Click(object sender, EventArgs e) => this.Close();

		private void toolStripMenuItemTopmost_CheckedChanged(object sender, EventArgs e) =>
			this.TopMost = toolStripMenuItemTopmost.Checked;

		private void toolStripMenuItemShowControls_CheckStateChanged(object sender, EventArgs e) =>
			SetVisibility(toolStripMenuItemShowControls.Checked);

		private void toolStripMenuItemShowDate_CheckedChanged(object sender, EventArgs e) =>
			checkBoxShowDate.Checked = toolStripMenuItemShowDate.Checked;

		private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e) =>
			toolStripMenuItemShowDate.Checked = checkBoxShowDate.Checked;

		private void toolStripMenuItemShowDay_CheckedChanged(object sender, EventArgs e) =>
			checkBoxShowWeekday.Checked = toolStripMenuItemShowDay.Checked;

		private void checkBoxShowWeekday_CheckedChanged(object sender, EventArgs e) =>
			toolStripMenuItemShowDay.Checked = checkBoxShowWeekday.Checked;

		private void toolStripMenuItemBackgroundColor_Click(object sender, EventArgs e)
		{
			colorDialog.Color = labelTime.BackColor;
			DialogResult result = colorDialog.ShowDialog(this);
			if (result == DialogResult.OK) labelTime.BackColor = colorDialog.Color;
		}

		private void toolStripMenuItemForegroundColor_Click(object sender, EventArgs e)
		{
			colorDialog.Color = labelTime.ForeColor;
			if (colorDialog.ShowDialog(this) == DialogResult.OK) labelTime.ForeColor = colorDialog.Color;
		}

		private void toolStripMenuItemChooseFont_Click(object sender, EventArgs e)
		{
			if (fontDialog.ShowDialog(this) == DialogResult.OK)
			{
				labelTime.Font = fontDialog.Font;
			}
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if (!this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void toolStripMenuItemShowConsole_CheckedChanged(object sender, EventArgs e)
		{
			//AllocConsole();
			bool show = toolStripMenuItemShowConsole.Checked ? AllocConsole() : FreeConsole();
		}
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		static extern bool FreeConsole();

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void toolStripMenuItemLoadOnWindowsStartup_CheckedChanged(object sender, EventArgs e)
		{
			string key_name = "Clock_VPD_311";
			RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			if (toolStripMenuItemLoadOnWindowsStartup.Checked) key.SetValue(key_name, Application.ExecutablePath);
			else key.DeleteValue(key_name, false);
			key.Dispose();
		}

		private void ToolStripMenuItemAlarms_Click(object sender, EventArgs e)
		{
			alarmsForm.ShowDialog();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
		private bool isDragging = false; // Флаг для отслеживания состояния перетаскивания
		private Point dragStartPoint;    // Точка начала перетаскивания

		// Обработчик события нажатия кнопки мыши
		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = true;
				dragStartPoint = e.Location;
			}
		}

		// Обработчик события перемещения мыши
		private void MainForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging)
			{
				this.Location = new Point(this.Location.X + e.X - dragStartPoint.X, this.Location.Y + e.Y - dragStartPoint.Y);
			}
		}

		// Обработчик события отпускания кнопки мыши
		private void MainForm_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = false;
			}
		}
		//private void toolStripMenuItemShowControls_CheckedChanged(object sender, EventArgs e)
		//{
		//	SetVisibility(toolStripMenuItemShowControls.Checked);
		//}



	}
}

