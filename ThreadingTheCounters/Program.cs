using System;
using System.Threading;

namespace ThreadingTheCounters
{
    class Program
    {
        static void Main(string[] args)
		{
			//Start 5 threads			
			for( int i = 0; i < 6; i++)	new Thread(DoThread).Start();

			//Do not close the console immidiatly
			Console.ReadLine();
		}

		public static void DoThread()
		{
			for (int i = 0; i < 101; i++)
			{
				Console.Write(i + " ");
			}
		}
	}
}
