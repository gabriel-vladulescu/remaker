using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Achievement.View
{
	public class AchievementPopupMediator : Mediator
	{
		[Inject]
		public AchievementPopup popup { get; set; }

		[Inject]
		public UpdateAchievementPopupSignal UpdateAchievementPopupSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
