﻿
namespace Clock
{
	partial class AddAlarmDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAlarmDialog));
			this.checkBoxUseDate = new System.Windows.Forms.CheckBox();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
			this.checkedListBoxWeekdays = new System.Windows.Forms.CheckedListBox();
			this.labelFilename = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCansel = new System.Windows.Forms.Button();
			this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
			this.buttonChooseFile = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBoxUseDate
			// 
			this.checkBoxUseDate.AutoSize = true;
			this.checkBoxUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxUseDate.Location = new System.Drawing.Point(13, 22);
			this.checkBoxUseDate.Name = "checkBoxUseDate";
			this.checkBoxUseDate.Size = new System.Drawing.Size(150, 36);
			this.checkBoxUseDate.TabIndex = 0;
			this.checkBoxUseDate.Text = "Use date";
			this.checkBoxUseDate.UseVisualStyleBackColor = true;
			this.checkBoxUseDate.CheckedChanged += new System.EventHandler(this.checkBoxUseDate_CheckedChanged);
			// 
			// dateTimePickerDate
			// 
			this.dateTimePickerDate.CustomFormat = "yyyy.MM.dd";
			this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDate.Location = new System.Drawing.Point(13, 65);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(180, 38);
			this.dateTimePickerDate.TabIndex = 1;
			// 
			// dateTimePickerTime
			// 
			this.dateTimePickerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerTime.Location = new System.Drawing.Point(199, 65);
			this.dateTimePickerTime.Name = "dateTimePickerTime";
			this.dateTimePickerTime.Size = new System.Drawing.Size(149, 38);
			this.dateTimePickerTime.TabIndex = 2;
			// 
			// checkedListBoxWeekdays
			// 
			this.checkedListBoxWeekdays.CheckOnClick = true;
			this.checkedListBoxWeekdays.ColumnWidth = 48;
			this.checkedListBoxWeekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkedListBoxWeekdays.FormattingEnabled = true;
			this.checkedListBoxWeekdays.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.checkedListBoxWeekdays.Location = new System.Drawing.Point(18, 113);
			this.checkedListBoxWeekdays.MultiColumn = true;
			this.checkedListBoxWeekdays.Name = "checkedListBoxWeekdays";
			this.checkedListBoxWeekdays.Size = new System.Drawing.Size(455, 119);
			this.checkedListBoxWeekdays.TabIndex = 3;
			this.checkedListBoxWeekdays.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxWeekdays_SelectedIndexChanged);
			// 
			// labelFilename
			// 
			this.labelFilename.AutoSize = true;
			this.labelFilename.Location = new System.Drawing.Point(15, 417);
			this.labelFilename.MaximumSize = new System.Drawing.Size(380, 0);
			this.labelFilename.Name = "labelFilename";
			this.labelFilename.Size = new System.Drawing.Size(69, 17);
			this.labelFilename.TabIndex = 4;
			this.labelFilename.Text = "Filename:";
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(322, 417);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 6;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCansel
			// 
			this.buttonCansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCansel.Location = new System.Drawing.Point(412, 417);
			this.buttonCansel.Name = "buttonCansel";
			this.buttonCansel.Size = new System.Drawing.Size(75, 23);
			this.buttonCansel.TabIndex = 6;
			this.buttonCansel.Text = "Cansel";
			this.buttonCansel.UseVisualStyleBackColor = true;
			// 
			// richTextBoxMessage
			// 
			this.richTextBoxMessage.Location = new System.Drawing.Point(18, 239);
			this.richTextBoxMessage.Name = "richTextBoxMessage";
			this.richTextBoxMessage.Size = new System.Drawing.Size(455, 81);
			this.richTextBoxMessage.TabIndex = 7;
			this.richTextBoxMessage.Text = "";
			this.richTextBoxMessage.TextChanged += new System.EventHandler(this.richTextBoxMessage_TextChanged);
			// 
			// buttonChooseFile
			// 
			this.buttonChooseFile.Location = new System.Drawing.Point(232, 417);
			this.buttonChooseFile.Name = "buttonChooseFile";
			this.buttonChooseFile.Size = new System.Drawing.Size(75, 23);
			this.buttonChooseFile.TabIndex = 8;
			this.buttonChooseFile.Text = "Обзор";
			this.buttonChooseFile.UseVisualStyleBackColor = true;
			this.buttonChooseFile.Click += new System.EventHandler(this.buttonChooseFile_Click);
			// 
			// AddAlarmDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 452);
			this.Controls.Add(this.buttonChooseFile);
			this.Controls.Add(this.richTextBoxMessage);
			this.Controls.Add(this.buttonCansel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.labelFilename);
			this.Controls.Add(this.checkedListBoxWeekdays);
			this.Controls.Add(this.dateTimePickerTime);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.checkBoxUseDate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddAlarmDialog";
			this.ShowInTaskbar = false;
			this.Text = "AddAlarmDialog";
			this.Load += new System.EventHandler(this.AddAlarmDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBoxUseDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerTime;
		private System.Windows.Forms.CheckedListBox checkedListBoxWeekdays;
		private System.Windows.Forms.Label labelFilename;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCansel;
		private System.Windows.Forms.RichTextBox richTextBoxMessage;
		private System.Windows.Forms.Button buttonChooseFile;
	}
}