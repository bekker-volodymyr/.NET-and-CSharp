using Interfaces.GameExample;

namespace Interfaces.DamageableExample
{
    public class Ally : IDamageable, IAttack
    {
        private float _health = 75f;
        public float Health => _health;

        private bool _isDead = false;
        public bool IsDead => _isDead;

        private float _damage = 10f;
        public float Damage => _damage;

        public void Death()
        {
            Console.WriteLine("Ally is dead!");
            _isDead = true;
        }

        public void GetDamage(float damage)
        {
            _health -= damage;

            Console.WriteLine($"Ally is attacked and gets {damage} damage. Health left: {_health}");

            if (_health < 0)
            {
                Death();
            }
        }

        public void Attack(IDamageable target)
        {
            if (target.IsDead)
            {
                return;
            }

            Console.WriteLine($"Ally is attacking! Do {Damage} damage!");
            target.GetDamage(Damage);
        }
    }
}
