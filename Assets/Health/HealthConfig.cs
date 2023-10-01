using UnityEngine;

namespace SI.Health
{
    [CreateAssetMenu(fileName = "HealthConfig_", menuName = "Health/Health Config")]
    public class HealthConfig : ScriptableObject
    {
        public int maxHealth;
    }
}