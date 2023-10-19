using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraOOP
{
    internal class Timer
    {
        
        public int remainingSeconds {  get; set; }

        public Timer(int remainingSeconds)
        {
            this.remainingSeconds = remainingSeconds;
        }

        public void SetTime(int seconds) {
            remainingSeconds = seconds;            
        }

        public void StartTimer() { 
            for (int i = remainingSeconds; i >= 0; i--) {
                if (i > 0)
                {
                    Console.WriteLine($"You have: {i} seconds.");
                }
                else
                {
                    Console.WriteLine("\n TIME TO WAKE UP!!");
                }
            }
        }
    }
}
