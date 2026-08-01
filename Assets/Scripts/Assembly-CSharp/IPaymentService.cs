public interface IPaymentService
{
	void BuyItem(string itemId, string payload);

	void OnInit();

	void OnConfigReady();

	bool IsProductsAlready();

	bool IsInterruptedTransaction(string transactionId);

	void OnProductListReceived(EventDelegate eventDelegate);

	void OnUserVariablesUpdated();

	PaymentModel GetPaymentModel();
}
