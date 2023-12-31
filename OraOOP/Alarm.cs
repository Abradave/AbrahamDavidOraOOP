﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraOOP
{
    internal class Alarm
    {
        public int alarmHour {  get; set; }
        public int alarmMinute { get; set; }

        public bool isAlarmon { get; set; }

        public Alarm(int alarmHour, int alarmMinute)
        {
            this.alarmHour = alarmHour;
            this.alarmMinute = alarmMinute;
        }

        public void SetAlarm(int hour, int minute) { 
            this.alarmHour = hour;
            this.alarmMinute = minute;
        }

        public void TurnOnAlarm() { 
            isAlarmon = true;
        }

        public void TurnOffAlarm() {  
            isAlarmon = false; 
        }

        public bool IsAlarmTime(int hour, int minute) {
            if (hour == this.alarmHour && minute == this.alarmMinute)
            {
                return true;
            }
            return false;
        }

    }
}
