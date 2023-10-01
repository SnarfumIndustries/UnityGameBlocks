using System;
using UnityEngine;

namespace SI.Health
{
    /// <summary>
    ///     Health management class for entities in the game.
    ///     The entity should be Damageable and Healable.
    /// </summary>
    public class Health : MonoBehaviour, IDamageable, IHealable
    {
        [SerializeField] private int _maxHealth = 100;
        [SerializeField] private int _currentHealth;
        public int Max { get; }
        public int Current { get; }

        /// <summary>
        ///     Event that gets triggered when the health value changes.
        ///     Parameters: oldHealth, newHealth
        /// </summary>
        public Action<int, int> OnHealthChanged;
        /// <summary>
        ///     Event that gets triggered when the health value decreases.
        ///     Parameter: newHealth
        /// </summary>
        public Action<int> OnHealthDecreased;
        /// <summary>
        ///     Event that gets triggered when the health value increases.
        ///     Parameter: newHealth
        /// </summary>
        public Action<int> OnHealthIncreased;
        /// <summary>
        ///     Event that gets triggered when health reaches zero.
        /// </summary>
        public Action OnDeath;

        #region Lifecycle
        private void Start()
        {
            _currentHealth = _maxHealth;
        }
        #endregion

        #region Public Methods
        public void Initialize(int maxHealth, int initialHealth)
        {
            _maxHealth = maxHealth;
            _currentHealth = initialHealth;
        }

        /// <summary>
        ///     TakeDamage method: Reduces the current health by the damage value.
        ///     Triggers OnHealthDecreased and OnHealthChanged events.
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage(int damage)
        {
            int oldHealth = _currentHealth;
            _currentHealth = Mathf.Max(0, _currentHealth - damage);

            if (OnHealthDecreased != null)
            {
                OnHealthDecreased(_currentHealth);
                OnHealthChanged?.Invoke(oldHealth, _currentHealth);
            }

            if (_currentHealth <= 0)
                OnDeath?.Invoke();
        }

        /// <summary>
        ///     Heal method: Increases the current health by the heal amount.
        ///     Triggers OnHealthIncreased and OnHealthChanged events.
        ///     Parameter: amount
        /// </summary>
        /// <param name="amount"></param>
        public void Heal(int amount)
        {
            int oldHealth = _currentHealth;
            _currentHealth += amount;
            _currentHealth = Mathf.Min(_currentHealth, _maxHealth);

            if (OnHealthIncreased != null)
            {
                OnHealthIncreased(_currentHealth);
                OnHealthChanged?.Invoke(oldHealth, _currentHealth);
            }
        }
        #endregion
    }
}