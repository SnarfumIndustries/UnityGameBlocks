using UnityEngine;

namespace SI.PlayerData
{
    public class ExamplePlayerDataController : MonoBehaviour
    {
        [SerializeField] private float _dateFileName;
        private PlayerService _playerService;

        private void Awake()
        {
            var playerData = new JsonDataManager<PlayerData>("playerData.json");
            var rewardsData = new JsonDataManager<RewardData>("rewardsData.json");

            _playerService = new PlayerService(playerData, rewardsData);

            //int xp = _playerService.GetXPForLevel(5);
        }
    }
}