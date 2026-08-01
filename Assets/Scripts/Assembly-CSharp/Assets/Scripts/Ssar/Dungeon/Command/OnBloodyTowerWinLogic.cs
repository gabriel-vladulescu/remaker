using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.Dungeon.Model;
using Scripts.Config;
using Ssar.Achievement;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class OnBloodyTowerWinLogic : IOnBattleWinLogic
	{
		private DungeonWinParameter parameter;

		private BloodyTowerFloorInfo floorInfo;

		private Metric metric;

		private AchievementLogic achievementLogic;

		private readonly MainCharacterData mainCharacterData;

		public OnBloodyTowerWinLogic(BloodyTowerFloorInfo floorInfo, Metric metric, AchievementLogic achievementLogic, MainCharacterData mainCharacterData)
		{
		}

		public void Prepare()
		{
		}

		public List<ItemInfo> GenerateReward(int floor, int star, ConfigManager configManager)
		{
			return null;
		}

		private void ValidateItemInfo(ref ItemInfo itemInfo, ConfigManager configManager)
		{
		}

		public void OnExcute(DungeonWinParameter parameter)
		{
		}

		private void AddEquipment(DungeonWinParameter winParameter)
		{
		}

		public DungeonWinParameter GenerateDungeonWinParameter()
		{
			return null;
		}

		private int CurrentFloor()
		{
			return 0;
		}

		public void OnExcute()
		{
		}

		private void SaveSoul(int soul)
		{
		}

		private void UpdateFirstAnniversaryQuest()
		{
		}
	}
}
