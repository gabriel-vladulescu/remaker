using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class UpdateFirstAnniversaryQuestProgressCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public QuestType QuestType { get; set; }

		[Inject]
		public int value { get; set; }

		[Inject]
		public UpdateFirstAnniversaryQuestpopupSignal UpdateFirstAnniversaryQuestpopupSignal { get; set; }

		public override void Execute()
		{
		}

		private FirstAnniversaryQuestData Data()
		{
			return null;
		}
	}
}
