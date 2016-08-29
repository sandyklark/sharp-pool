namespace SharpPool
{
	public interface IPool<T> where T : IPoolable
	{
		string id { get; }

		void Initialize(int amount);
		T Get(int amount = 1);
		void Return(T poolObject);
		void Clear();
	}
}