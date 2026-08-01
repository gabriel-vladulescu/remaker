namespace Ssar.Shop.Model
{
	public abstract class AbsFlashSaleRateUpCondition
	{
		protected MainCharacterData mainCharacterData;

		protected int conditionValue;

		public AbsFlashSaleRateUpCondition(MainCharacterData mainCharacterData, int conditionValue)
		{
		}

		public abstract bool IsMeetCondition();
	}
}
