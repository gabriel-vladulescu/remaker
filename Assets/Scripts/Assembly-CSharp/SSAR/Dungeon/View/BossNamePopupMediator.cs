using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class BossNamePopupMediator : Mediator
	{
		[Inject]
		public BossNamePopup view { get; set; }

		[Inject]
		public HideBossNamePopupSignal HideBossNamePopupSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void Hide()
		{
		}
	}
}
