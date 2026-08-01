using Assets.Scripts.Ssar.Iap;
using UnityEngine.Purchasing;

namespace Ssar.Iap
{
	public class PaymentResultSuccessInfo
	{
		public bool Success { get; private set; }

		public Product Product { get; private set; }

		public string Error { get; private set; }

		public PurchaseValidationResult PurchaseValidationResult { get; private set; }

		public PaymentResultSuccessInfo(bool success, Product product, string error, PurchaseValidationResult purchaseValidationResult)
		{
		}
	}
}
