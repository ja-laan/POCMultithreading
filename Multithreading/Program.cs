using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
		//Wait for one thread to be finished 
		public static EventWaitHandle handle1 = new AutoResetEvent(false);
		public static EventWaitHandle handle2 = new AutoResetEvent(false);

		public static void FirstThread()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.Write(i + " ");

				//Signal handle 1 and let handle 2 wait
				EventWaitHandle.SignalAndWait(handle1, handle2);
			}
		}


		public static void SecondThread()
		{
			for (int i = 0; i < 5; i++)
			{
				Console.Write(i + " ");

				//Signal handle 2 and let handle 1 wait
				EventWaitHandle.SignalAndWait(handle2, handle1);
			}
		}

		public static void Main(string[] args)
		{
			//start 2 threads
			new Thread(FirstThread).Start();
			new Thread(SecondThread).Start();

			//Do not close the console immidiatly
			Console.ReadLine();
		}
	}
}
