using Assets.Scripts.Ssar.Signal;
using Scripts.Ssar.Arena;
using Ssar.Analytics.Metrics;
using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class EnterDuelArenaCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public EnterDuelArenaParameter Parameter { get; set; }

		[Inject]
		public DailyQuestLogic dql { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestProgressSignal UpdateFirstAnniversaryQuestProgressSignal { get; set; }

		public override void Execute()
		{
		}

		private void AncientMetric(MainCharacterData characterData)
		{
		}

		private void MarketingMetric(MainCharacterData mainCharacterData)
		{
		}
	}
}
