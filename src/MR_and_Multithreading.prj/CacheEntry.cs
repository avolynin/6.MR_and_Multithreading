using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MR_and_Multithreading
{
	class CacheEntry<T> : ICacheEntry<T> where T : class
	{
		private bool disposedValue;
		public T Value { get; }

		public CacheEntry(T value)
		{
			Value = value;
		}

		protected virtual void Dispose(bool disposing)
		{
			if(!disposedValue)
			{
				if(disposing)
				{
					
				}
				disposedValue = true;
			}
		}

		~CacheEntry()
		{
			Dispose(false);
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
