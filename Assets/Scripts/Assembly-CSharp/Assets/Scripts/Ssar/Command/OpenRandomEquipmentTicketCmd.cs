using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class OpenRandomEquipmentTicketCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public OpenRandomEquipmentTicketParameter Parameter { get; set; }

		[Inject]
		public DailyQuestLogic dql { get; set; }

		public override void Execute()
		{
		}
	}
}
