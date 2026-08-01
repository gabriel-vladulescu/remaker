using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class RaidBossConfigToRawDungeonConfigAdapter : RawDungeonConfig
	{
		private class RawDungeonImplement : RawDungeon
		{
			private RaidBossConfig.Room room;

			public RawDungeonImplement(RaidBossConfig.Room room)
			{
			}

			public int[] StageIds()
			{
				return null;
			}

			public int Id()
			{
				return 0;
			}
		}

		private RaidBossConfig config;

		public RaidBossConfigToRawDungeonConfigAdapter(RaidBossConfig config)
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
