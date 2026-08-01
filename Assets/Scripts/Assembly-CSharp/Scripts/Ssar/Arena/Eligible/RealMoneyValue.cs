namespace Scripts.Ssar.Arena.Eligible
{
	public class RealMoneyValue : IEligibleValue
	{
		private double realMoneySpent;

		public RealMoneyValue(double realMoneySpent)
		{
		}

		public int Value()
		{
			return 0;
		}
	}
}
