using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR_and_Multithreading
{
	public class MyBiggestObject
	{
		public readonly byte[] Memory = new byte[5];

		/// <summary>Заполнение памяти рандомными числами.</summary>
		public void FillMemoryRandom()
		{
			Random random = new Random();
			for(int i = 0; i < Memory.Length; i++)
			{
				Memory[i] = (byte)random.Next(byte.MinValue, byte.MaxValue);
				Console.WriteLine($"{i} = {Memory[i]}");
			}
		}
	}
}

