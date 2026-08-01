using Assets.Scripts.Ssar.Dungeon.HellMode;
using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.Dungeon.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using Scripts.Config;
using Ssar.Achievement;
using Ssar.Analytics.Metrics;
using Ssar.DailyQuest;
using Ssar.Event.SevenDaysCampaign;
using strange.extensions.injector.api;
using strange.extensions.signal.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class OnAdventureWinLogic : IOnBattleWinLogic
	{
		private HellModeLogic hellModeLogic;

		private ConfigManager configManager;

		private AchievementLogic achievementLogic;

		private DailyQuestLogic dql;

		private CampaignLogic campaignLogic;

		private Metric metric;

		private ICrossContextInjectionBinder injectionBinder;

		private readonly MainCharacterData _mainCharacterData;

		private DungeonWinParameter parameter;

		public OnAdventureWinLogic(ICrossContextInjectionBinder injectionBinder, MainCharacterData mainCharacterData)
		{
		}

		public void OnExcute()
		{
		}

		public void Prepare()
		{
		}

		private void SendMetricLevelUp()
		{
		}

		public DungeonWinParameter GenerateDungeonWinParameter()
		{
			return null;
		}

		public Signal<DungeonWinParameter> ShowWinPopupSignal()
		{
			return null;
		}

		private void AutoPickUpAllEquipmentOfLastStage()
		{
		}

		private void Win(DungeonWinParameter parameter)
		{
		}

		private void UpdateProgress(DungeonWinParameter winParameter)
		{
		}

		private void AddEquipment(DungeonWinParameter winParameter)
		{
		}

		private void AddSoul(DungeonWinParameter winParameter)
		{
		}

		private void AddExp(DungeonWinParameter winParameter)
		{
		}

		private void AddShard(DungeonWinParameter winParameter)
		{
		}

		private void SaveSoul(DungeonWinParameter winParameter)
		{
		}

		private void CheckUnlockFeatures()
		{
		}

		private string FindEquippingEquipmentRarity(MainCharacterData mcd, EquipmentType equipmentType)
		{
			return null;
		}

		private bool FindEquippingEquipment(MainCharacterData mcd, EquipmentType equipmentType, ref EquipmentCollectData equipmentCollectData)
		{
			return false;
		}

		private bool FindEquippingEquipment(MainCharacterData mcd, EquipmentType equipmentType, ref int collectedId)
		{
			return false;
		}

		private bool FindEquippingEquipment(MainCharacterData mcd, int collectedId, ref EquipmentCollectData equipmentCollectData)
		{
			return false;
		}

		private void CheckAnhNotiAskForRate(DungeonWinParameter dungeonWinParameter)
		{
		}

		private bool IsTutorial()
		{
			return false;
		}

		private void UpdateFirstAnniversaryQuest()
		{
		}

		private void UpdateXmasWarQuest(DungeonWinParameter dungeonWinParameter)
		{
		}
	}
}
