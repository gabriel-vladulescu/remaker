using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.SkillSystem.View
{
	public class PurchaseSkillPointPopupMediator : Mediator
	{
		[Inject]
		public PurchaseSkillPointPopup view { get; set; }

		[Inject]
		public OnPurchaseSkillPointSuccessSignal OnPurchaseSkillPointSuccessSignal { get; set; }

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
