using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace MR_and_Multithreading
{
	public class Program
	{
		static void Main(string[] args)
		{
			var cache = new WeakReferenceCache<MyBiggestObject>(() 
				=> new MyBiggestObject());
			
			using(var entry = cache.GetEntry())
			{
				ProcessData(entry.Value);
			}
		}

		static void ProcessData(MyBiggestObject entry)
		{
			Console.WriteLine($"Length of memory: {entry.Memory.Length}");
		}
	}
}
