using UnityEngine;

namespace SI.Utilities
{
    /// <summary>
    ///     Singleton class
    /// </summary>
    /// <typeparam name="T">Type of the singleton</typeparam>
    public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        /// <summary>
        ///     The static reference to the instance
        /// </summary>
        public static T Instance { get; private set; }

        /// <summary>
        ///     Gets whether an instance of this singleton exists
        /// </summary>
        public static bool instanceExists => Instance != null;

        /// <summary>
        ///     Awake method to associate singleton with instance
        /// </summary>
        protected virtual void Awake()
        {
            if (instanceExists)
            {
                Destroy(gameObject);	// Destroy new instance if one already exists
            }
            else
            {
                Instance = (T) this;
            }
        }

        /// <summary>
        ///     OnDestroy method to clear singleton association
        /// </summary>
        protected virtual void OnDestroy()
        {
            if (Instance == this)
                Instance = null;
        }
    }

    /// <summary>
    ///     Singleton class
    /// </summary>
    /// <typeparam name="T">Type of the singleton</typeparam>
    public abstract class PersistantSingleton<T> : Singleton<T> where T : Singleton<T>
    {
        /// <summary>
        ///     Awake method to associate singleton with instance and prevent destruction on load
        /// </summary>
        protected override void Awake()
        {
            base.Awake();

            if (!instanceExists)
            {
                DontDestroyOnLoad(this);
            }
        }
    }
}