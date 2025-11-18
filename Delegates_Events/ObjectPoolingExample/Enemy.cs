namespace ObjectPoolingExample
{
    public class Enemy : IPoolable
    {
        private float MaxHealth = 100f;
        public float Health { get; private set; }

        // Позиція в ігровому світі
        public float X { get; private set; }
        public float Y { get; private set; }

        public Action<IPoolable> ReturnCallback { get; set; }

        public void Reset(float x, float y)
        {
            Health = MaxHealth;
            X = x;
            Y = y;
        }

        public void Death()
        {
            ReturnCallback.Invoke(this);
        }
    }
}
