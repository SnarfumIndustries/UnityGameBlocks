using System;
using System.Collections;
using UnityEngine;

namespace SI.Extensions
{
    /// <summary>
    ///     Provides extension methods for the <see cref="UnityEngine.MonoBehaviour" />.
    /// </summary>
    public static class MonoBehaviourExtensions
    {
        /// <summary>
        ///     Invokes the action after a delay, safely within a coroutine.
        /// </summary>
        /// <param name="behaviour">The MonoBehaviour this method extends.</param>
        /// <param name="delayInSeconds">The delay before the method is invoked, in seconds.</param>
        /// <param name="action">The Action to invoke.</param>
        public static void InvokeSafe(this MonoBehaviour behaviour, float delayInSeconds, Action action)
        {
            behaviour.StartCoroutine(InvokeSafeRoutine(delayInSeconds, action));
        }

        /// <summary>
        ///     Invokes the action repeatedly with an initial delay and a repeating interval, safely within a coroutine.
        /// </summary>
        /// <param name="behaviour">The MonoBehaviour this method extends.</param>
        /// <param name="delayInSeconds">The initial delay before the method is invoked, in seconds.</param>
        /// <param name="intervalInSeconds">The time interval between each invocation, in seconds.</param>
        /// <param name="action">The Action to invoke.</param>
        /// <returns>Reference to the Coroutine instance.</returns>
        public static Coroutine InvokeRepeatingSafe(this MonoBehaviour behaviour, float delayInSeconds,
            float intervalInSeconds, Action action)
        {
            return behaviour.StartCoroutine(InvokeSafeRepeatingRoutine(delayInSeconds, intervalInSeconds, action));
        }

        /// <summary>
        ///     Coroutine that delays the invocation of an action.
        /// </summary>
        /// <param name="delayInSeconds">The delay before invoking the action, in seconds.</param>
        /// <param name="action">The Action to invoke.</param>
        /// <returns>An iterator for the coroutine.</returns>
        private static IEnumerator InvokeSafeRoutine(float delayInSeconds, Action action)
        {
            yield return new WaitForSeconds(delayInSeconds);
            action?.Invoke();
        }

        /// <summary>
        ///     Coroutine that repeatedly invokes an action with an initial delay and a repeating interval.
        /// </summary>
        /// <param name="delayInSeconds">The initial delay, in seconds.</param>
        /// <param name="intervalInSeconds">The time interval between each invocation, in seconds.</param>
        /// <param name="action">The Action to invoke.</param>
        /// <returns>An iterator for the coroutine.</returns>
        private static IEnumerator InvokeSafeRepeatingRoutine(float delayInSeconds, float intervalInSeconds,
            Action action)
        {
            yield return new WaitForSeconds(delayInSeconds);

            while (true)
            {
                action?.Invoke();
                yield return new WaitForSeconds(intervalInSeconds);
            }
        }
    }
}