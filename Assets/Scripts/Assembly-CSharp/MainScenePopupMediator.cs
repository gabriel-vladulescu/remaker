using strange.extensions.mediation.impl;

// Simplified: the real game injects several purchase-success signals here
// (OnBuyFirstTopUpPackageSuccessSignal/OnBuyPiggyBankSuccessSignal/
// BuyUnlockAllCharactersPackageSuccessSignal/
// BuyFlashSaleOreRuneBundleSuccessSignal) to update shop-related UI state.
// None of those shop/IAP systems are reimplemented, and none of those
// signals are bound via commandBinder anywhere in this project, so - same
// StrangeIoC Injector gotcha as UserButtonInputLayoutMediator - leaving
// them [Inject]'d would throw at Mediator construction rather than
// injecting null.
public class MainScenePopupMediator : Mediator
{
	[Inject]
	public MainScenePopup view { get; set; }

	public override void OnRegister()
	{
	}

	public override void OnRemove()
	{
	}
}
