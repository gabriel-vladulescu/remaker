namespace Ssar.Shop.Model
{
	public class LegendaryEquipmentLessThanCondition : AbsFlashSaleRateUpCondition
	{
		public LegendaryEquipmentLessThanCondition(MainCharacterData mainCharacterData, int conditionValue)
			: base(null, 0)
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}
	}
}
