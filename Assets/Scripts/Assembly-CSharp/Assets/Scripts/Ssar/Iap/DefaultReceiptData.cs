using Ssar.Iap;

namespace Assets.Scripts.Ssar.Iap
{
	public class DefaultReceiptData : ReceiptData
	{
		private UserData userData;

		public DefaultReceiptData(UserData userData)
		{
		}

		public bool ContainReceiptWithId(string id)
		{
			return false;
		}

		public void RecognizeReceiptWithId(string id)
		{
		}
	}
}
