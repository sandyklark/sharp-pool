namespace SharpPool
{
	public interface IPoolManager
	{
		void AddPool(IPool pool);
		void InitializePool(string poolId, int poolSize);
		void InitializePools(int poolSize);
		IPool GetPoolById(string poolId);
		void ClearPool(string poolId);
		void ClearPools();
	}
}