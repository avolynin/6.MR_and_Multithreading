using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR_and_Multithreading
{
	public interface ICacheEntry<T> : IDisposable where T: class
	{
		public T Value { get; }
	}
}
