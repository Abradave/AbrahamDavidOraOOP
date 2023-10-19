using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraOOP
{
    internal class Clock
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public string timeZone { get; set; }
        public bool is24HourFormat { get; set; }

        public Clock(int hour, int minute, int second, string timeZone , bool is24HourFormat)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.timeZone = timeZone;
            this.is24HourFormat = is24HourFormat;
        }

        public void SetTime(int hour, int minute, int second) { 
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void DisplayTime() {

            Console.WriteLine($"The time is set to: {hour}:{minute}:{second} {timeZone}");
        }

        public void SetTimeZone(string timeZone) {
            this.timeZone = timeZone;
        }

        public void ToogleFormat() {
            if (is24HourFormat == false && this.hour >= 12 && this.minute >= 0 && this.second > 0)
            {
                this.hour = this.hour - 12;
            }
        }
    }
}
