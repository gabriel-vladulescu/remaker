using SSAR.WorldMap.Model;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.StarChest.View
{
	public class StarChestRewardPopupRow : MonoBehaviour
	{
		public UILabel lb_star;

		public UILabel lb_desc;

		public GameObject rewardContainer;

		public GameObject wgReceived;

		private RewardReceiveView ReceiveView;

		private void Awake()
		{
		}

		public void Show(ScenarioStarChestRewardInfo rewardInfo, DungeonConfig dungeonConfig, WorldMapData worldMapData)
		{
		}
	}
}
