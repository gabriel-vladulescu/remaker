using Assets.Scripts.Ssar.Signal;
using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class ConsumeCrystalCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int value { get; set; }

		[Inject]
		public DailyQuestLogic dailyQuestLogic { get; set; }

		[Inject]
		public string source { get; set; }

		[Inject]
		public Reason Reason { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestProgressSignal UpdateFirstAnniversaryQuestProgressSignal { get; set; }

		public override void Execute()
		{
		}

		private void UpdateMoreThanCrystal()
		{
		}

		private void UpdateDailyQuest()
		{
		}

		private void UpdateFirstAnniversaryQuest()
		{
		}
	}
}
