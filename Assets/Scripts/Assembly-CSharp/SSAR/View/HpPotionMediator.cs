using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.Dungeon.View;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class HpPotionMediator : Mediator
	{
		[Inject]
		public HpPotionView view { get; set; }

		[Inject]
		public HideHpPotionViewSignal HideHpPotionViewSignal { get; set; }

		[Inject]
		public OnUseHpPotionSuccessSignal OnUseHpPotionSuccessSignal { get; set; }

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
