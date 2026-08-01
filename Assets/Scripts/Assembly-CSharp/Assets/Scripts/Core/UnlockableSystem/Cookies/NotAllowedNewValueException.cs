using System;

namespace Assets.Scripts.Core.UnlockableSystem.Cookies
{
	public class NotAllowedNewValueException : Exception
	{
		private int propertyId;

		private int currentValue;

		private int newValue;

		public NotAllowedNewValueException(string message, int propertyId, int currentValue, int newValue)
		{
		}

		public int getPropertyId()
		{
			return 0;
		}

		public int getCurrentValue()
		{
			return 0;
		}

		public int getNewValue()
		{
			return 0;
		}
	}
}
