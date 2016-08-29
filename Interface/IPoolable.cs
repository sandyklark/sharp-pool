namespace SharpPool
{
	internal interface IPoolable
	{
		void SetPool(IPool pool);
		void ReturnToPool();
	}
}