namespace Ssar.Shop.Model
{
	public class SoulLessThanCondition : AbsFlashSaleRateUpCondition
	{
		public SoulLessThanCondition(MainCharacterData mainCharacterData, int conditionValue)
			: base(null, 0)
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}
	}
}
