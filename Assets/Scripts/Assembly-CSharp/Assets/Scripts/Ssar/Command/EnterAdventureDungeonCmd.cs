using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class EnterAdventureDungeonCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int nodeId { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestProgressSignal UpdateFirstAnniversaryQuestProgressSignal { get; set; }

		public override void Execute()
		{
		}

		private void CheckAndConsumeBoostItem()
		{
		}

		private void SendMetrics()
		{
		}

		private void AncientMetric(MainCharacterData characterData)
		{
		}
	}
}
