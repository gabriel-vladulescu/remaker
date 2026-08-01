using Assets.Scripts.Ssar.CharacterSelection.Model;
using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.DailyQuest;
using UnityEngine.Purchasing;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Iap.Command
{
	public class OnPurchaseResultCommand : strange.extensions.command.impl.Command
	{
		private const string DISPLAY_NAME = "Zonmob";

		private DungeonConfig dungeonConfig;

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public bool success { get; set; }

		[Inject]
		public Product product { get; set; }

		[Inject]
		public string error { get; set; }

		[Inject]
		public PurchaseValidationResult purchaseValidationResult { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public BuySubscriptionPackageSuccessSignal buySubscriptionPackageSuccessSignal { get; set; }

		[Inject]
		public CreateCharacterSignal CreateCharacterSignal { get; set; }

		[Inject]
		public BuyDoubleExpPackageSuccessSignal BuyDoubleExpPackageSuccessSignal { get; set; }

		[Inject]
		public BuyFlashSaleItemSuccessSignal BuyFlashSaleItemSuccessSignal { get; set; }

		[Inject]
		public BuyUnlockAllCharactersPackageSuccessSignal BuyUnlockAllCharactersPackageSuccessSignal { get; set; }

		[Inject]
		public BuyFlashSaleOreRuneBundleSuccessSignal BuyFlashSaleOreRuneBundleSuccessSignal { get; set; }

		[Inject]
		public BuyShopBlackFridayItemSuccessSignal BuyShopBlackFridayItemSuccessSignal { get; set; }

		[Inject]
		public DailyQuestLogic dailyQuestLogic { get; set; }

		public override void Execute()
		{
		}

		private void TrackingRevenue(string sku, string packName, double revenue, string currency)
		{
		}

		private void ProcessUnlockAllCharacters(UnlockAllCharactersPackageProductInfo productInfo)
		{
		}

		private void ProcessFlashSaleOreRuneBundle(FlashSaleOreRuneBundleProductInfo productInfo)
		{
		}

		private void ProcessLevelUpProduct(NewLevelUpPackageProductInfo productInfo)
		{
		}

		private void ProcessCrystalProduct(ShopCrystalProductInfo scpi)
		{
		}

		private void ProcessBundlePackageProduct(BundlePackageProductInfo scpi)
		{
		}

		private void ProcessFirstTopUpPacakge(FirstTimePurchaseProductInfo productInfo)
		{
		}

		private void ProcessPiggyBank(PiggyBankItem productInfo)
		{
		}

		private void ProcessEventTokenProduct(EventShopTokenProductInfo tokenProduct)
		{
		}

		private void SendMetricBuyHero(string sku, CharacterCode parameterCharacterCode, double price, string currencyCode)
		{
		}

		private void SendMetricCrystal(ShopCrystalProductInfo p, double price, string currencyCode)
		{
		}

		private void SendMetricBundle(BundlePackageProductInfo bppi, double price, string currencyCode)
		{
		}

		private void SendMetricFirstTimePurchase(FirstTimePurchaseProductInfo ftppi, double price, string currencyCode)
		{
		}

		private void SendMetricLevelUpPackage(NewLevelUpPackageProductInfo nlppi, double price, string currencyCode)
		{
		}

		private void SendMetricNewSubscribePackage(NewSubscribePackageProductInfo nsppi, double price, string currencyCode)
		{
		}

		private void SendMetricPiggyBank(PiggyBankItem bppi, double price, string currencyCode)
		{
		}

		private void SendMetricDoubleExpPackage(DoubleExpPackageProductInfo deppi, double price, string currencyCode)
		{
		}

		private void SendMetricFlashSale(FlashSaleItemInfo fsii, double price, string currencyCode)
		{
		}

		private void SendMetricBuyAllHero(string sku, double price, string currencyCode)
		{
		}

		private void SendMetricFlashSaleOreRuneBundle(string sku, double price, string currencyCode)
		{
		}

		private void AddRealMoneySpent(double realMoney)
		{
		}
	}
}
