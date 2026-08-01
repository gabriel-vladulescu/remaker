using strange.extensions.command.impl;

namespace Ssar.Event.Xmas
{
	public class UpdateXmasWarQuestProgressCmd : Command
	{
		[Inject]
		public UpdateXmasWarQuestProgressParameters Parameters { get; set; }

		public override void Execute()
		{
		}

		private int CalculatePoint(XmasWarQuest warQuest)
		{
			return 0;
		}

		private int CalculateTowerPoint(XmasWarQuest warQuest)
		{
			return 0;
		}
	}
}
