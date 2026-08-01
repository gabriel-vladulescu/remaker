using UnityEngine.Purchasing;
using strange.extensions.signal.impl;

namespace Assets.Scripts.Ssar.Iap.Command
{
	public class OnPurchaseResultSignal : Signal<bool, Product, string, PurchaseValidationResult>
	{
	}
}
