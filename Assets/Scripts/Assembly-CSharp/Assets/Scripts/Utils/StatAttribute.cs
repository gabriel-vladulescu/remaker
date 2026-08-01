using System;

namespace Assets.Scripts.Utils
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class StatAttribute : Attribute
	{
		private string name;

		private TransferType type;

		public StatAttribute(string abilitiesName, TransferType transferType)
		{
		}

		public string GetName()
		{
			return null;
		}

		public TransferType GetTransferType()
		{
			return default(TransferType);
		}
	}
}
