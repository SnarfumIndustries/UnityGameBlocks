using UnityEngine;
using UnityEngine.UI;

namespace SI.Extensions
{
    public static class GraphicExtensions
    {
        /// <summary>
        ///     Sets the alpha level of the given <paramref name="graphic" /> to the specified <paramref name="newAlpha" /> value.
        /// </summary>
        /// <param name="graphic">The <see cref="UnityEngine.UI.Graphic" /> to modify.</param>
        /// <param name="newAlpha">The new alpha level in a range from 0.0 (fully transparent) to 1.0 (fully opaque).</param>
        /// <typeparam name="T">The type of the <see cref="UnityEngine.UI.Graphic" />.</typeparam>
        /// <returns>The modified <see cref="UnityEngine.UI.Graphic" /> with the new alpha level applied.</returns>
        public static T SetAlpha<T>(this T graphic, float newAlpha)
            where T : Graphic
        {
            // Make sure that newAlpha is in the range [0, 1]
            newAlpha = Mathf.Clamp(newAlpha, 0f, 1f);

            // Make the changes on a local copy to minimize the impact on performance
            Color color = graphic.color;
            color.a = newAlpha;
            graphic.color = color;

            return graphic;
        }
    }
}