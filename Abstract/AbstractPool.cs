using System;
using System.Collections.Generic;

namespace SharpPool
{
	public abstract class AbstractPool<T> where T : IPool
	{
		public string id { get; }

		protected List<T> _poolObjects;

		public void Initialize(string poolId, int amount)
		{
			id = poolId;
			_poolObjects = new List<T>();

			for(int i = 0; i < amount; i++)
			{
				_poolObjects.Add( new T() );
			}
		}

		public T Get(int amount = 1)
		{
			if(_poolObjects.Count > 0)
			{
				T poolObject = _poolObjects[0];
				_poolObjects.Remove(poolObject);

				return poolObject;
			}else
			{
				throw new Error("Pool Empty - Try increasing the initial pool size");
			}
		}

		public void Return(T poolObject)
		{
			if(!_poolObject.Contains(poolObject))
			{
				_poolObjects.Add(poolObject);
			}
		}

		public void Clear()
		{
			_poolObjects = new List<T>();
		}
	}
}