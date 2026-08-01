namespace Ssar.Iap
{
	public interface ReceiptData
	{
		bool ContainReceiptWithId(string id);

		void RecognizeReceiptWithId(string id);
	}
}
