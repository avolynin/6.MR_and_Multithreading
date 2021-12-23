using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MR_and_Multithreading
{
	/// <summary>Реализует ICache используя WeakReference для хранения записи.</summary>
	class WeakReferenceCache<T> : ICache<T> where T: class
	{
		private static object _locker = new object();
		private Func<T> _func; 
		private WeakReference<ICacheEntry<T>> _ref;

		public WeakReferenceCache(Func<T> func)
		{
			_func = func;
			_ref = new WeakReference<ICacheEntry<T>>(new CacheEntry<T>(_func()));
		}

		/// <summary>Если ссылка более не существует, создается объект снова.</summary>
		/// <returns>Запись кэша.</returns>
		public ICacheEntry<T> GetEntry()
		{
			lock(_locker)
			{
				ICacheEntry<T> entry = null;
				if(!_ref.TryGetTarget(out entry))
				{
					entry = new CacheEntry<T>(_func());
					_ref = new WeakReference<ICacheEntry<T>>(entry);
				}
				return entry;
			}
		}
	}
}
