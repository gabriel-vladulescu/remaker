using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class LevelUpPackagePopupMediator : Mediator
	{
		[Inject]
		public LevelUpPackagePopup view { get; set; }

		[Inject]
		public OnBuyLevelUpPackageSuccessSignal OnBuyLevelUpPackageSuccessSignal { get; set; }

		[Inject]
		public OnClaimRewardOfLevelUpPackageSuccessSiggnal OnClaimRewardOfLevelUpPackageSuccessSiggnal { get; set; }

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
