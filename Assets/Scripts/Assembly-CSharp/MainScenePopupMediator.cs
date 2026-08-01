using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.mediation.impl;

public class MainScenePopupMediator : Mediator
{
	[Inject]
	public MainScenePopup view { get; set; }

	[Inject]
	public OnBuyFirstTopUpPackageSuccessSignal OnBuyFirstTopUpPackageSuccessSignal { get; set; }

	[Inject]
	public OnBuyPiggyBankSuccessSignal OnBuyPiggyBankSuccessSignal { get; set; }

	[Inject]
	public BuyUnlockAllCharactersPackageSuccessSignal BuyUnlockAllCharactersPackageSuccessSignal { get; set; }

	[Inject]
	public BuyFlashSaleOreRuneBundleSuccessSignal BuyFlashSaleOreRuneBundleSuccessSignal { get; set; }

	public override void OnRegister()
	{
	}

	public override void OnRemove()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnBuyFirstTopUpSuccess(FirstTimePurchaseProductInfo productInfo)
	{
	}

	private void OnBuyPiggybank()
	{
	}
}
