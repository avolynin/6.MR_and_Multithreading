namespace MR_and_Multithreading
{
	/// <summary>Представляет кэш локальной памяти.</summary>
	interface ICache<T> where T: class
	{
		/// <summary>Если ссылка более не существует, создается объект снова.</summary>
		/// <returns>Запись кэша.</returns>
		ICacheEntry<T> GetEntry();
	}
}
