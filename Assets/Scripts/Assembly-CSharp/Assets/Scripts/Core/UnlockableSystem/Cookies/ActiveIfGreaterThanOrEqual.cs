namespace Assets.Scripts.Core.UnlockableSystem.Cookies
{
	public class ActiveIfGreaterThanOrEqual : ActivationRule
	{
		public bool IsActive(int propertyValue, int activationValue)
		{
			return false;
		}

		public bool IsNewValueAllowed(int currentValue, int newValue)
		{
			return false;
		}

		public string toString()
		{
			return null;
		}
	}
}
