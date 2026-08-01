using Assets.Scripts.Ssar.Dungeon.Command;
using Scripts.Config;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class OnAdventureLoseLogic : IOnBattleLoseLogic
	{
		private readonly MainCharacterData _mainCharacterData;

		public OnAdventureLoseLogic(MainCharacterData mainCharacterData)
		{
		}

		public void OnExcute(Metric metric, ConfigManager configManager, DungeonLoseReason reason)
		{
		}

		private void UpdateProgress(int nodeId, DungeonConfig dungeonConfig)
		{
		}

		private void SendDungeonLoseMetric(Metric metric, int nodeId, DungeonLoseReason Reason)
		{
		}

		private void SendCorpse()
		{
		}

		private void UpdateFirstAnniversaryQuest()
		{
		}

		private void UpdateXmasWarQuest(int dungeonId)
		{
		}
	}
}
