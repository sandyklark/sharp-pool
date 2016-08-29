using System;
using System.Collections.Generic;

namespace SharpPool
{
	public abstract class AbstractPoolManager : IPoolManager
	{
		protected Dictionary<string, IPool> _pools;

		public void AddPool(IPool pool)
		{
			if(_pools == null) _pools = new Dictionary<string, IPool>();

			_pools.Add(pool.id, pool);
		}

		public void InitializePool(string poolId, int poolSize)
		{
			IPool pool = _pools[poolId];
			pool.Initialize(poolSize);
		}
		
		public void InitializePools(int poolSize)
		{
			foreach(IPool pool in _pools)
			{
				pool.Initialize(poolSize);
			}
		}
		
		public IPool GetPoolById(string poolId)
		{
			return _pools[poolId];
		}

		public void ClearPool(string poolId)
		{
			IPool pool = _pools[poolId];
			pool.Clear();
		}
		
		public void ClearPools()
		{
			foreach(IPool pool in _pools)
			{
				pool.Clear();
			}
		}
		
	}
}