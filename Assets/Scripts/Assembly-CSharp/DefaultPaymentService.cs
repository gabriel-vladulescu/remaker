using System.Collections.Generic;

public class DefaultPaymentService : IPaymentService
{
	public const string PAYMENT_KEY = "default_payment";

	private PaymentModel paymentModel;

	private HashSet<string> interruptedTransactions;

	[Inject]
	public DataService dataService { get; set; }

	[PostConstruct]
	public void Init()
	{
	}

	public void BuyItem(string itemId, string payload)
	{
	}

	public void OnInit()
	{
	}

	public void OnConfigReady()
	{
	}

	public bool IsProductsAlready()
	{
		return false;
	}

	public bool IsInterruptedTransaction(string transactionId)
	{
		return false;
	}

	public void OnProductListReceived(EventDelegate eventDelegate)
	{
	}

	public void OnUserVariablesUpdated()
	{
	}

	public PaymentModel GetPaymentModel()
	{
		return null;
	}
}
