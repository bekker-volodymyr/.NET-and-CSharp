using Interfaces.GameExample;

namespace Interfaces.DamageableExample
{
    public class Enemy : IDamageable, IAttack
    {
        public float _health = 50f;
        public float Health => _health;

        private bool _isDead = false;
        public bool IsDead => _isDead;

        private float _damage = 5f;
        public float Damage => _damage;

        public void GetDamage(float damage)
        {
            _health -= damage;

            Console.WriteLine($"Enemy is attacked and gets {damage} damage. Health left: {_health}");

            if (_health < 0)
            {
                Death();
            }
        }
        public void Death()
        {
            Console.WriteLine("Enemy is dead!");
            _isDead = true;
        }
        public void Attack(IDamageable target)
        {
            Console.WriteLine($"Enemey attacks! Do {Damage} damage!");
            target.GetDamage(Damage);
        }
    }
}
