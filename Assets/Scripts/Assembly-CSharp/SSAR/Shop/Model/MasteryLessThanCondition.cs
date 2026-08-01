namespace Ssar.Shop.Model
{
	public class MasteryLessThanCondition : AbsFlashSaleRateUpCondition
	{
		public MasteryLessThanCondition(MainCharacterData mainCharacterData, int conditionValue)
			: base(null, 0)
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}
	}
}
