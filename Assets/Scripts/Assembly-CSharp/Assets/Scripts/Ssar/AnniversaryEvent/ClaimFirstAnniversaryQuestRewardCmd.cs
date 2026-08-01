using Assets.Scripts.Ssar.Signal;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class ClaimFirstAnniversaryQuestRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public QuestInfo QuestInfo { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestpopupSignal UpdateFirstAnniversaryQuestpopupSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void GenerateReward(QuestInfo questInfo)
		{
		}

		private void GenerateNewQuest(QuestInfo questInfo)
		{
		}

		private FirstAnniversaryQuestData Data()
		{
			return null;
		}

		private void Metrics(QuestInfo questInfo)
		{
		}
	}
}
