using System;
using System.Collections.Generic;
using AppsFlyerSDK;
using Ssar.Iap;
using UnityEngine;
using UnityEngine.Purchasing;

namespace Assets.Scripts.Ssar.Iap
{
	public class Purchaser : MonoBehaviour, IStoreListener, IAppsFlyerValidateReceipt
	{
		private const string googlePublicKey = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAogUb55a/81DkBkAs4N4xlBOj7hM6LymI3eZWKyyzF12KY/PbcmrX062Pfvcs+O4e6EjpsPjdHnoX7G1CPqpfp4MnAX5PDhAI+QGZS+X8FZSFQrg2aC/EUyPJMttsZ+6/Id8VEiCRfQrz56+BBberInJnnt+CBbEFftwmqsCkzKzFHc5MZqi5iWwcFcF8MCZ6rEgIzvsUfyBTLarG+DyT2aFiKcXZoehRHsrv20KPnA4bYSpQws+WgzkukXexxokNAfmnI2ld0cgvIluD8UFyfag6MhO95vvTlZr0rfaD7GCokyujbhqKhEkpxe7KkQPepYCUnrnRBwZU1U+76PZSGwIDAQAB";

		private static IStoreController m_StoreController;

		private static IExtensionProvider m_StoreExtensionProvider;

		private Action<bool, string> initListener;

		private Action<bool, Product, string, bool> purchaseListener;

		private ReceiptData receiptData;

		public void ListenToInitResult(Action<bool, string> listener)
		{
		}

		public void ListenToPurchaseResult(Action<bool, Product, string, bool> listener)
		{
		}

		public void InitializePurchasing(List<string> consumeableProductIds, ReceiptData receiptData)
		{
		}

		public void UpdateReceiptData(ReceiptData receiptData)
		{
		}

		private bool IsInitialized()
		{
			return false;
		}

		public bool LocalizedPrice(string productId, ref string isoCurrencyCode, ref decimal localizedPrice, ref string localizedPriceString)
		{
			return false;
		}

		public void BuyProductID(string productId)
		{
		}

		public void RestorePurchases()
		{
		}

		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error)
		{
		}

		public void OnInitializeFailed(InitializationFailureReason error, string message)
		{
		}

		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)
		{
			return default(PurchaseProcessingResult);
		}

		private void ValidateIAPAppsflyer(PurchaseEventArgs args)
		{
		}

		public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
		{
		}

		private bool ValidatePurchase(PurchaseEventArgs args)
		{
			return false;
		}

		public void didFinishValidateReceipt(string result)
		{
		}

		public void didFinishValidateReceiptWithError(string error)
		{
		}
	}
}
