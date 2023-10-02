using System;
using UnityEngine;

namespace SI.Extensions
{
    /// <summary>
    ///     Provides extension methods for Vector2, Vector3, and Vector4 Unity types with enhanced features.
    /// </summary>
    public static class Vector234Extensions
    {
        #region Vector2
        /// <summary>
        ///     Sets the x component of the Vector2.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="newXValue">The new x-value to replace.</param>
        /// <returns>The updated Vector2.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided value is NaN or Infinity.</exception>
        public static Vector2 SetX(this Vector2 vector, float newXValue)
        {
            if (IsInvalid(newXValue))
                throw new ArgumentException("Invalid value provided for x.");

            vector.x = newXValue;
            return vector;
        }

        /// <summary>
        ///     Sets the y component of the Vector2.
        /// </summary>
        /// <param name="vector">The original Vector2.</param>
        /// <param name="newYValue">The new y-value to replace.</param>
        /// <returns>The updated Vector2.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided value is NaN or Infinity.</exception>
        public static Vector2 SetY(this Vector2 vector, float newYValue)
        {
            if (IsInvalid(newYValue))
                throw new ArgumentException("Invalid value provided for y.");

            vector.y = newYValue;
            return vector;
        }
        #endregion

        // Vector3

        #region Vector3
        /// <summary>
        ///     Sets the x component of the Vector3.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="newXValue">The new x-value to replace.</param>
        /// <returns>The updated Vector3.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided value is NaN or Infinity.</exception>
        public static Vector3 SetX(this Vector3 vector, float newXValue)
        {
            if (IsInvalid(newXValue))
                throw new ArgumentException("Invalid value provided for x.");

            vector.x = newXValue;
            return vector;
        }

        /// <summary>
        ///     Sets the y component of the Vector3.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="newYValue">The new y-value to replace.</param>
        /// <returns>The updated Vector3.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided value is NaN or Infinity.</exception>
        public static Vector3 SetY(this Vector3 vector, float newYValue)
        {
            if (IsInvalid(newYValue))
                throw new ArgumentException("Invalid value provided for y.");

            vector.y = newYValue;
            return vector;
        }

        /// <summary>
        ///     Sets the z component of the Vector3.
        /// </summary>
        /// <param name="vector">The original Vector3.</param>
        /// <param name="newZValue">The new z-value to replace.</param>
        /// <returns>The updated Vector3.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided value is NaN or Infinity.</exception>
        public static Vector3 SetZ(this Vector3 vector, float newZValue)
        {
            if (IsInvalid(newZValue))
                throw new ArgumentException("Invalid value provided for z.");

            vector.z = newZValue;
            return vector;
        }
        #endregion

        #region Vector4
        /// <summary>
        ///     Sets the x component of the Vector4.
        /// </summary>
        /// <param name="vector">The original Vector4.</param>
        /// <param name="newXValue">The new x-value to replace.</param>
        /// <returns>The updated Vector4.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided value is NaN or Infinity.</exception>
        public static Vector4 SetX(this Vector4 vector, float newXValue)
        {
            if (IsInvalid(newXValue))
                throw new ArgumentException("Invalid value provided for x.");

            vector.x = newXValue;
            return vector;
        }

        /// <summary>
        ///     Sets the y component of the Vector4.
        /// </summary>
        /// <param name="vector">The original Vector4.</param>
        /// <param name="newYValue">The new y-value to replace.</param>
        /// <returns>The updated Vector4.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided value is NaN or Infinity.</exception>
        public static Vector4 SetY(this Vector4 vector, float newYValue)
        {
            if (IsInvalid(newYValue))
                throw new ArgumentException("Invalid value provided for y.");

            vector.y = newYValue;
            return vector;
        }

        /// <summary>
        ///     Sets the z component of the Vector4.
        /// </summary>
        /// <param name="vector">The original Vector4.</param>
        /// <param name="newZValue">The new z-value to replace.</param>
        /// <returns>The updated Vector4.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided value is NaN or Infinity.</exception>
        public static Vector4 SetZ(this Vector4 vector, float newZValue)
        {
            if (IsInvalid(newZValue))
                throw new ArgumentException("Invalid value provided for z.");

            vector.z = newZValue;
            return vector;
        }

        /// <summary>
        ///     Sets the w component of the Vector4.
        /// </summary>
        /// <param name="vector">The original Vector4.</param>
        /// <param name="newWValue">The new w-value to replace.</param>
        /// <returns>The updated Vector4.</returns>
        /// <exception cref="ArgumentException">Thrown if the provided value is NaN or Infinity.</exception>
        public static Vector4 SetW(this Vector4 vector, float newWValue)
        {
            if (IsInvalid(newWValue))
                throw new ArgumentException("Invalid value provided for w.");

            vector.w = newWValue;
            return vector;
        }
        #endregion

        #region Private Methods
        /// <summary>
        ///     Checks if the provided float value is either NaN or Infinity.
        /// </summary>
        private static bool IsInvalid(float value)
        {
            return float.IsNaN(value) || float.IsInfinity(value);
        }
        #endregion
    }
}