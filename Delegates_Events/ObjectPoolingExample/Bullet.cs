namespace ObjectPoolingExample
{
    public class Bullet : IPoolable
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Action<IPoolable> ReturnCallback { get; set; }

        public void Reset(float x, float y)
        {
            X = x;
            Y = y;
        }

        public void OnHit()
        {
            ReturnCallback.Invoke(this);
        }
    }
}
