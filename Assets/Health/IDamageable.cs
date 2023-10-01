namespace SI.Health
{
    public interface IDamageable
    {
        /// <summary>
        ///     Method for an object to take damage.
        /// </summary>
        /// <param name="damage">The amount of damage taken by the object.</param>
        void TakeDamage(int damage);
    }
}