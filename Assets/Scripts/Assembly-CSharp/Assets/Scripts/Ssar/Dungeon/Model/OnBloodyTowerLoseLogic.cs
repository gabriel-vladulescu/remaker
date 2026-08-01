using Assets.Scripts.Ssar.Dungeon.Command;
using Scripts.Config;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class OnBloodyTowerLoseLogic : IOnBattleLoseLogic
	{
		private BloodyTowerFloorInfo floorInfo;

		private readonly MainCharacterData _mainCharacterData;

		public OnBloodyTowerLoseLogic(BloodyTowerFloorInfo floorInfo, MainCharacterData mainCharacterData)
		{
		}

		public void OnExcute(Metric metric, ConfigManager configManager, DungeonLoseReason reason)
		{
		}

		private void UpdateFirstAnniversaryQuest()
		{
		}
	}
}
