using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class TestLevelDesignConfigToRawDungeonConfigAdapter : RawDungeonConfig
	{
		private TestLevelDesignDungeonConfig config;

		public TestLevelDesignConfigToRawDungeonConfigAdapter(TestLevelDesignDungeonConfig config)
		{
		}

		public RawDungeon GetDungeonInfo(int dungeonId)
		{
			return null;
		}

		public RawStage Stage(int id)
		{
			return null;
		}
	}
}
