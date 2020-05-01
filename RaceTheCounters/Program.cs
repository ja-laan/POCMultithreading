using System;
using System.Threading;

namespace RaceTheCounters
{
    class Program
    {
        static void Main(string[] args)
        {
            var race = new RaceClass();

            var thread1 = new Thread(race.Thread1);
            var thread2 = new Thread(race.Thread2);
            var thread3 = new Thread(race.Thread3);

            WaitHandle[] waitHandles = new WaitHandle[] { race.event2, race.event3 };
            thread1.Start();
            thread2.Start();
            thread3.Start();
            WaitHandle.WaitAny(new WaitHandle[] { race.event1 });


            Console.WriteLine(race.racerint);
            Console.ReadLine();
        }
    }
}
