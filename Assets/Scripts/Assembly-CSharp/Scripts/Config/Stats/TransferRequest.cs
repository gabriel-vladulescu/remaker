using Assets.Scripts.Utils;

namespace Scripts.Config.Stats
{
	public class TransferRequest
	{
		public string attributeName;

		public TransferType type;

		public TransferRequest(string attributeName, TransferType type)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
