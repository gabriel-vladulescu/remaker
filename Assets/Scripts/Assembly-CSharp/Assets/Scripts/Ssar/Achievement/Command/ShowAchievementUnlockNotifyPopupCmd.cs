using System;

namespace Assets.Scripts.Ssar.Achievement.Command
{
	public class ShowAchievementUnlockNotifyPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public QuestUnlockNotifyParameter parameter { get; set; }

		[Inject]
		public Action onFinish { get; set; }

		public override void Execute()
		{
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
		}
	}
}
