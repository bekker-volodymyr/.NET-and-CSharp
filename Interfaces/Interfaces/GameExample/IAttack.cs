using Interfaces.DamageableExample;

namespace Interfaces.GameExample
{
    public interface IAttack
    {
        float Damage { get; }
        void Attack(IDamageable target);
    }
}
