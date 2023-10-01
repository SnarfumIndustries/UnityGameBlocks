namespace SI.Health
{
    public interface IHealable
    {
        /// <summary>
        ///     Restores the health of an entity by the specified amount.
        /// </summary>
        /// <param name="amount">The amount of health to restore.</param>
        void Heal(int amount);
    }
}