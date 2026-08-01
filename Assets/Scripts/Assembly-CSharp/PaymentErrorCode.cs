public enum PaymentErrorCode
{
	OK = 0,
	PurchaseNetworkError = 1,
	PurchaseDuplicateTransactionId = 2,
	PurchaseFailedEvent = 3,
	PurchaseCancelledEvent = 4,
	PurchaseErrorPayload = 5,
	PurchasePending = 6
}
