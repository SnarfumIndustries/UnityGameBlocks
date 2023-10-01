namespace SI.PlayerData
{
    public class PlayerService
    {
        private readonly JsonDataManager<PlayerData> _playerDataManager;
        private readonly JsonDataManager<RewardData> _otherDataManager;

        public PlayerService(JsonDataManager<PlayerData> playerDataManager, JsonDataManager<RewardData> otherDataManager)
        {
            _playerDataManager = playerDataManager;
            _otherDataManager = otherDataManager;
        }

        // public int GetXPForLevel(int level)
        // {
        //     PlayerData playerData = _playerDataManager.GetData();
        //     RewardData otherData = _otherDataManager.GetData();
        //
        //     // Logic to calculate XP for a specific level combining PlayerData and OtherData
        //     return level * otherData.someValue; // just an example
        // }
    }
}