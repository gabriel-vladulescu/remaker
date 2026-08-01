using Scripts.Config;

namespace Ssar.Analytics.Metrics.Generals
{
	public class DefaultGeneralData : GeneralData
	{
		private BaseData baseData;

		public DefaultGeneralData(BaseData baseData)
		{
		}

		public string Version()
		{
			return null;
		}

		public CharacterName CharacterName()
		{
			return default(CharacterName);
		}

		public string Level()
		{
			return null;
		}

		public float PlayingTime()
		{
			return 0f;
		}
	}
}
