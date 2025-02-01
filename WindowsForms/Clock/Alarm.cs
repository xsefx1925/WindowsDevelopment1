﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class Alarm: IComparable<Alarm>
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public Week Week { get; set; }
		public string Filename { get; set; }
		public string Message { get; set; }
		public Alarm()
		{
			this.Week = new Week();
		}

	//	public Alarm() { }
		public Alarm(Alarm other)
		{
			this.Date = other.Date;
			this.Time = other.Time;
			this.Week = new Week(other.Week);
			this.Filename = other.Filename;
			this.Message = other.Message;
		}
		public static bool operator >(Alarm left, Alarm right)
		{
			return left.Time > right.Time;
		}
		public static bool operator <(Alarm left, Alarm right)
		{
			return left.Time < right.Time;
		}
		public int CompareTo(Alarm other)
		{
			return this.Time.CompareTo(other.Time);
		}
		public override string ToString()
		{
			string info = "";
				
			info += $"{ (DateTime.Now.Date+Time).ToString("hh:mm:ss")}\t{this.Week}\t{this.Filename.Split('\\').Last()}\t";
			if (this.Date != DateTime.MinValue) info += this.Date.ToString("yyyy.MM.dd");
			//info += $"{this.Time.ToString("h'h:m'm:s's")}\t{this.Week}\t{this.Filename}";
			//info += this.Time;
			//info += this.Week;
			//info += this.Filename; 

			return info;

		}
	}
}