using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Timing
    {
        TimeSpan duration;
        public Timing()
        {
            duration = new TimeSpan(0);
        }
        public void StopTime()
        {
            duration = Process.GetCurrentProcess().TotalProcessorTime;
        }
        public void StartTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public TimeSpan Result()
        {
            return duration;
        }
    }
}
