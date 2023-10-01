using System;
using UnityEngine;

namespace SI.PlayerData
{
    /// <summary>
    ///     Represents a reward that a player can earn at a specific level.
    ///     Examples of rewards can be game items, new skills, character outfits, etc.
    /// </summary>
    [Serializable]
    public class RewardData
    {
        [SerializeField] private int _level;
        [SerializeField] private string _description;

        // Suggestion:
        // Consider replacing these string fields with specific classes depending
        // on the kind of reward you want to give to the players.
        // For instance, here are a few examples:
        // [SerializeField] private Item _rewardItem;
        // [SerializeField] private Skill _rewardSkill;
        // [SerializeField] private CharacterOutfit _rewardOutfit;

        /// <summary>
        ///     Gets the level at which the reward can be earned.
        /// </summary>
        public int Level => _level;

        /// <summary>
        ///     Gets the description of what the reward would be.
        /// </summary>
        public string Description => _description;

        /// <summary>
        ///     Initializes a new instance of the RewardData class.
        /// </summary>
        /// <param name="level">The level at which the reward can be earned.</param>
        /// <param name="description">A description of the reward.</param>
        public void Initialize(int level, string description)
        {
            _level = level;
            _description = description;
        }

        // Suggestion:
        // Consider creating methods to assign the actual models (Items, Skills, Outfits) to
        // the reward data, something like the examples below:
        // public void AssignRewardItem(Item rewardItem) {...}
        // public void AssignRewardSkill(Skill rewardSkill) {...}
        // public void AssignRewardOutfit(CharacterOutfit rewardOutfit) {...}
    }
}