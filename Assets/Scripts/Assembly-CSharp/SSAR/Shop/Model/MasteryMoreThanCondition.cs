namespace Ssar.Shop.Model
{
	public class MasteryMoreThanCondition : AbsFlashSaleRateUpCondition
	{
		public MasteryMoreThanCondition(MainCharacterData mainCharacterData, int conditionValue)
			: base(null, 0)
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}
	}
}
