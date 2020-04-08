using System;
using System.Threading;

namespace MultithreadingPOC
{
    class Program
    {		public static void Main(string[] args)
		{
			//Start 2 threads
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
			}
		}

		
	}
}
