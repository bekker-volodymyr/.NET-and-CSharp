namespace ObjectPoolingExample
{
    public interface IPoolable
    {
        Action<IPoolable> ReturnCallback { get; set; }

        void Reset(float x, float y);
    }
}
