using UnityEngine;

namespace SI.Extensions
{
    public static class LayerMaskExtensions
    {
        /// <summary>
        ///     Checks whether a LayerMask contains a specific layer.
        /// </summary>
        /// <param name="mask">The LayerMask to check.</param>
        /// <param name="layer">The index of the layer to search for.</param>
        /// <returns>true if the LayerMask contains the layer, otherwise false.</returns>
        public static bool Contains(this LayerMask mask, int layer)
        {
            return mask == (mask | (1 << layer));
        }
    }
}