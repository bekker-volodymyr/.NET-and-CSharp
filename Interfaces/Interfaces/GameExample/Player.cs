using Interfaces.GameExample;

namespace Interfaces.DamageableExample
{
    public class Player : IDamageable, IAttack
    {
        private float _health = 100f;
        public float Health => _health;
        private float _armorReductionValue = 5f;

        private bool _isDead = false;
        public bool IsDead => _isDead;

        private float _damage = 25f;
        public float Damage => _damage;

        public void GetDamage(float damage)
        {
            _health -= damage - _armorReductionValue;

            Console.WriteLine($"Player is attacked and gets {damage} damage. Health left: {_health}");

            if (_health < 0)
            {
                Death();
            }
        }

        public void Death()
        {
            Console.WriteLine("Game Over!");
            _isDead = true;
        }

        public void Attack(IDamageable target)
        {
            Console.WriteLine($"Player attacks! Do {Damage} damage!");
            target.GetDamage(Damage);
        }
    }
}
