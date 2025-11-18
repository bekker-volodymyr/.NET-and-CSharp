namespace ObjectPoolingExample
{
    public class ObjectPool<T> where T : IPoolable, new()
    {
        private Queue<T> _pool = new Queue<T>();

        public T GetObject()
        {
            T obj;
            if (_pool.Count == 0)
            {
                obj = new T();
                obj.ReturnCallback = ReturnObject;
            }
            else
            {
                obj = _pool.Dequeue();
            }

            return obj;
        }

        public void ReturnObject(IPoolable obj)
        {
            if (obj is T returnObj)
            {
                _pool.Enqueue(returnObj);
                return;
            }
            throw new InvalidCastException();
        }
    }
}
