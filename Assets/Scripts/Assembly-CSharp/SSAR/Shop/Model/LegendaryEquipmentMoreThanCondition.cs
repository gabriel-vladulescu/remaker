namespace Ssar.Shop.Model
{
	public class LegendaryEquipmentMoreThanCondition : AbsFlashSaleRateUpCondition
	{
		public LegendaryEquipmentMoreThanCondition(MainCharacterData mainCharacterData, int conditionValue)
			: base(null, 0)
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}
	}
}
