using System.Collections.Generic;

public class GooglePlayPaymentService : IPaymentService
{
	public const int BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED = 7;

	public const string PAYMENT_KEY = "googlePlay_payment";

	private PaymentModel paymentModel;

	private HashSet<string> interruptedTransactions;

	private string justRequestedItemId;

	[Inject]
	public DataService dataService { get; set; }

	[PostConstruct]
	public void Init()
	{
	}

	public void OnInit()
	{
	}

	public void OnConfigReady()
	{
	}

	public void OnUserVariablesUpdated()
	{
	}

	public void BuyItem(string itemId, string payload)
	{
	}

	public PaymentModel GetPaymentModel()
	{
		return null;
	}

	public bool IsInterruptedTransaction(string transactionId)
	{
		return false;
	}

	public bool IsProductsAlready()
	{
		return false;
	}

	public void OnProductListReceived(EventDelegate eventDelegate)
	{
	}

	private void InitOpenIab()
	{
	}

	private void ValidatePendingTransactions()
	{
	}

	private void billingSupportedEvent()
	{
	}

	private void billingNotSupportedEvent(string error)
	{
	}

	private void queryInventoryFailedEvent(string error)
	{
	}
}
