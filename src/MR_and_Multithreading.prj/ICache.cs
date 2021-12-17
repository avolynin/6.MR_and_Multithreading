namespace MR_and_Multithreading
{
	interface ICache<T> where T: class
	{
		ICacheEntry<T> GetEntry();
	}
}
