using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RaceTheCounters
{
    class RaceClass
    {
        public int racerint { get; private set; }
        public AutoResetEvent event1 { get; set; }
        public AutoResetEvent event2 { get; set; }
        public AutoResetEvent event3 { get; set; }

        public RaceClass()
        {
            event1 = new AutoResetEvent(false);
            event2 = new AutoResetEvent(false);
            event3 = new AutoResetEvent(false);
            racerint = 0;
        }
 

        public void Thread1()
        {
            WaitHandle.WaitAll(new WaitHandle[] { event2, event3 });
            racerint = 1;
            event1.Set();
        }
        public void Thread2()
        {
            racerint = 2;
            event2.Set();
        }
        public void Thread3()
        {
            racerint = 3;
            event3.Set();
        }
    }
}
