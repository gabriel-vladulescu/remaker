namespace Ssar.Shop.Model
{
	public class CrystalLessThanCondition : AbsFlashSaleRateUpCondition
	{
		public CrystalLessThanCondition(MainCharacterData mainCharacterData, int conditionValue)
			: base(null, 0)
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}
	}
}
