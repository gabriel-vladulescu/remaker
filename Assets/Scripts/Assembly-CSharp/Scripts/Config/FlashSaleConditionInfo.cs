namespace Scripts.Config
{
	public class FlashSaleConditionInfo
	{
		public int id;

		public string conditionType;

		public int conditionValue;

		public int[] itemIdBonusRate;

		public double bonusRate;

		public bool enable { get; set; }
	}
}
