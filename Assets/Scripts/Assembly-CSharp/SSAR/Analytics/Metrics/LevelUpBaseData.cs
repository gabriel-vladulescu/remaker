namespace Ssar.Analytics.Metrics
{
	public class LevelUpBaseData : BaseData
	{
		private int level;

		public LevelUpBaseData(MainCharacterData mainCharacterData, int level)
			: base(null)
		{
		}

		public override string LevelString()
		{
			return null;
		}
	}
}
