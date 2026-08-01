using Ssar.Achievement;
using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class AddCharacterSoulCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int value { get; set; }

		[Inject]
		public string source { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		[Inject]
		public DailyQuestLogic dailyQuestLogic { get; set; }

		[Inject]
		public RewardReason RewardReason { get; set; }

		public override void Execute()
		{
		}
	}
}
