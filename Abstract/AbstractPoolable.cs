using System;

namespace SharpPool
{
	public abstract class AbstractPoolable : IPoolable
	{
		public IPool pool { get; }

		public void SetPool(IPool parentPool)
		{
			pool = parentPool;
		}
		
		public void ReturnToPool()
		{
			pool.Return(this);
		}
	}
}