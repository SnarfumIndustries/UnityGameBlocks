using System;
using UnityEngine;

namespace SI.PlayerData
{
    [Serializable]
    public class PlayerData
    {
        // Private fields
        [SerializeField] private string _id;
        [SerializeField] private string _playerName;
        [SerializeField] private int _level;
        [SerializeField] private int _experience;
        [SerializeField] private long _createdDate;
        [SerializeField] private long _modifiedDate;

        // Public properties
        public string Id => _id;
        public string PlayerName => _playerName;
        public int Level => _level;
        public int Experience => _experience;
        public DateTime CreatedDate => new DateTime(_createdDate);
        public DateTime ModifiedDate => new DateTime(_modifiedDate);

        /// <summary>
        ///     Initializes a new instance of the PlayerData class.
        /// </summary>
        /// <param name="playerName">The name of the player.</param>
        /// <param name="level">The level of the player.</param>
        /// <param name="experience">The experience of the player.</param>
        public void Initialize(string playerName, int level, int experience)
        {
            _id = Guid.NewGuid().ToString();
            _playerName = playerName;
            _level = level;
            _experience = experience;
            _createdDate = DateTime.Now.Ticks;
            _modifiedDate = _createdDate;
        }

        /// <summary>
        ///     Updates the ModifiedDate of the player data to the current date and time.
        /// </summary>
        public void UpdateModifiedDate()
        {
            _modifiedDate = DateTime.Now.Ticks;
        }
    }
}