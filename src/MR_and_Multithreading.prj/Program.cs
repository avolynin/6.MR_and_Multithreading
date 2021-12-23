using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace MR_and_Multithreading
{
	public class Program
	{
		static void Main(string[] args)
		{
			var cache = new WeakReferenceCache<MyBiggestObject>(() 
				=> new MyBiggestObject());

			Thread[] threads = new Thread[5];
			using(var entry = cache.GetEntry())
			{
				for(int i = 0; i < 5; i++)
				{
					threads[i] = new Thread(entry.Value.FillMemoryRandom)
					{
						Name = "Thread №" + i.ToString(),
						IsBackground = true
					};
					threads[i].Start();
					threads[i].Join();
				}
			}
		}
	}
}
