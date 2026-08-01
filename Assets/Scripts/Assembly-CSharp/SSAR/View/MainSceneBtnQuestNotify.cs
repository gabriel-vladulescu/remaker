using Assets.Scripts.Ssar.Achievement.View;

namespace SSAR.View
{
	public class MainSceneBtnQuestNotify : AbsButtonNofity
	{
		private DailyQuestNotify notify;

		private AchievementNotify achievementNotify;

		protected override void Awake()
		{
		}

		protected override bool IsNotify()
		{
			return false;
		}

		private bool DailyLogin()
		{
			return false;
		}

		private bool DailyQuest()
		{
			return false;
		}

		private bool Achievement()
		{
			return false;
		}
	}
}
