using UnityEngine;

namespace SI.Extensions
{
    /// <summary>
    ///     Provides extension methods for the Material class.
    /// </summary>
    public static class MaterialExtensions
    {
        /// <summary>
        ///     Sets the alpha value of the material's color.
        /// </summary>
        /// <param name="material">The material whose alpha value to set.</param>
        /// <param name="toAlpha">The alpha value to set.</param>
        /// <returns>
        ///     The material with its alpha value adjusted, clamped between 0 and 1.
        ///     Null if the material was null.
        /// </returns>
        public static Material SetAlpha(this Material material, float toAlpha)
        {
            // Check for null material
            if (material == null)
            {
                Debug.LogWarning("SetAlpha was called on a null material.");
                return null;
            }

            // Clamp alpha value to ensure that it is between 0 and 1
            float clampedAlpha = Mathf.Clamp(toAlpha, 0f, 1f);

            // Set alpha
            Color color = material.color;
            color.a = clampedAlpha;
            material.color = color;

            return material;
        }
    }
}