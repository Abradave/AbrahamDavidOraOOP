using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Clock myClock = new Clock(12,30,45,"UTC +2", true);
            Timer timer = new Timer(10);
            List<Alarm> alarm = new List<Alarm>();
            Alarm alarm1 = new Alarm(6,0);
            Alarm alarm2 = new Alarm(8,0);

            alarm.Add(alarm1);
            alarm.Add(alarm2);

            myClock.DisplayTime();
            foreach (var item in alarm)
            {
                if(item.IsAlarmTime(myClock.hour, myClock.minute) == true) {
                    Console.WriteLine("Az ébresztő megszólalt.");
                }
            }
            timer.StartTimer();

            Console.ReadKey();
        }
    }
}
