using System;
using System.Threading;

namespace MultithreadingBarrier
{
    class Program
    {
		//Create a barrier of 3 threads, this means this 3 threads each runs their first sequence and then print an empty line before going to the next sequence of threads
		public static Barrier barrier = new Barrier(3, barrier => Console.WriteLine());

		public static void Main(string[] args)
		{
			//start three threads
			new Thread(DoThread).Start();
			new Thread(DoThread).Start();
			new Thread(DoThread).Start();

			//Do not close the console immidiatly
			Console.ReadLine();
		}

		public static void DoThread()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.Write(i + " ");

				//Signal the barrier this thread have done his task and is ready for the next task 
				barrier.SignalAndWait();
			}
		}

		
	}
}
