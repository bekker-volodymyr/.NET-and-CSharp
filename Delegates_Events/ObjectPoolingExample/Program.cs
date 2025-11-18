namespace ObjectPoolingExample
{
    internal class Program
    {
        private static ObjectPool<Bullet> _bulletsPool = new ObjectPool<Bullet>();
        private static ObjectPool<Enemy> _enemyPool = new ObjectPool<Enemy>();

        static void Main(string[] args)
        {
            Bullet bullet = _bulletsPool.GetObject();
            Enemy enemy = _enemyPool.GetObject();

            bullet.OnHit();
            enemy.Death();
        }
    }
}
