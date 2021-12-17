using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MR_and_Multithreading
{
	class WeakReferenceCache<T> : ICache<T> where T: class
	{
		private Func<T> _func;
		private WeakReference<ICacheEntry<T>> _ref;

		public WeakReferenceCache(Func<T> func)
		{
			_func = func;
			_ref = new WeakReference<ICacheEntry<T>>(new CacheEntry<T>(_func()));
		}

		public ICacheEntry<T> GetEntry()
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
