namespace Ssar.Shop.Model
{
	public class LevelLessThanCondition : AbsFlashSaleRateUpCondition
	{
		public LevelLessThanCondition(MainCharacterData mainCharacterData, int conditionValue)
			: base(null, 0)
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}
	}
}
