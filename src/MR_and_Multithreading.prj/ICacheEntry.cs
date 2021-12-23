using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MR_and_Multithreading
{
	/// <summary>Представляет запись в реализации ICache.</summary>
	public interface ICacheEntry<T> : IDisposable where T: class
	{
		/// <summary>Значение записи кэша.</summary>
		public T Value { get; }
	}
}
