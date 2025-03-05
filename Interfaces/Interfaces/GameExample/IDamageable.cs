namespace Interfaces.DamageableExample
{
    public interface IDamageable
    {
        float Health { get; }
        void GetDamage(float damage);
        void Death();
        bool IsDead { get; }
    }
}
