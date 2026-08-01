using SSAR.WorldMap.Model;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.StarChest.View
{
	public class StarChestProgressChestView : MonoBehaviour
	{
		public UISprite sp_chest;

		public UILabel lb_starRequire;

		public GameObject btn_click;

		private GameObject fx;

		private bool canOpen;

		private ScenarioStarChestRewardInfo rewardInfo;

		private MapInfo mapInfo;

		private ScenarioDifficulty difficulty;

		private TweenRotation tweenRotation;

		private TweenPosition tweenPosition;

		private void Awake()
		{
		}

		public void Show(int index, ScenarioStarChestRewardInfo rewardInfo, WorldMapData worldMapData, DungeonConfig dungeonConfig)
		{
		}

		public void Hide()
		{
		}

		private string GetExtra(StarChestStatus status)
		{
			return null;
		}

		private void ActiveFx(bool active)
		{
		}

		private void InitFx()
		{
		}

		private void Open(GameObject o)
		{
		}

		private void EnableTween(bool active)
		{
		}
	}
}
