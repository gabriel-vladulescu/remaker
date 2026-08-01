using System;

[Serializable]
public class Purchase
{
	public string uid { get; set; }

	public string ItemType { get; set; }

	public string OrderId { get; set; }

	public string PackageName { get; set; }

	public string Sku { get; set; }

	public string PurchaseTime { get; set; }

	public int PurchaseState { get; set; }

	public string DeveloperPayload { get; set; }

	public string Token { get; set; }

	public string OriginalJson { get; set; }

	public string Signature { get; set; }

	public string AppstoreName { get; set; }
}
