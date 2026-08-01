using System;
using System.Collections.Generic;
using Scripts.Config;
using UnityEngine.Purchasing;

namespace Assets.Scripts.Ssar.Iap
{
	public class PaymentService
	{
		private UserData userData;

		private bool initSuccessful;

		private string initError;

		private Purchaser purchaser;

		private Action<bool, string> initListener;

		private Action<bool, Product, string, PurchaseValidationResult> purchaseListener;

		private bool isPurchaseInProgress;

		private Action<string, float> onPreBuy;

		public void Init(ConfigManager configManager, UserData userData)
		{
		}

		public void UpdateUserData(UserData userData)
		{
		}

		private List<string> GetSkus(ConfigManager configManager)
		{
			return null;
		}

		public void ListenToInitResult(Action<bool, string> initListener)
		{
		}

		public void ListenToPurchaseResult(Action<bool, Product, string, PurchaseValidationResult> purchaseListener)
		{
		}

		public void ListenToOnPreBuy(Action<string, float> listener)
		{
		}

		public void UnlistenToOnPreBuy(Action<string, float> listener)
		{
		}

		public bool LocalizedPrice(string productId, ref string isoCurrencyCode, ref decimal localizedPrice, ref string localizedPriceString)
		{
			return false;
		}

		public void BuyProduct(string id)
		{
		}

		private void OnPurchaseResult(bool success, Product product, string error, bool isPurchaseValid)
		{
		}

		private void OnInitResult(bool success, string error)
		{
		}
	}
}
