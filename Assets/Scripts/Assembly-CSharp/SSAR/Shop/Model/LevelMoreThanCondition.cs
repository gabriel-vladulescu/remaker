namespace Ssar.Shop.Model
{
	public class LevelMoreThanCondition : AbsFlashSaleRateUpCondition
	{
		public LevelMoreThanCondition(MainCharacterData mainCharacterData, int conditionValue)
			: base(null, 0)
		{
		}

		public override bool IsMeetCondition()
		{
			return false;
		}
	}
}
