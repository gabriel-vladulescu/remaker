using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class DailyChallengeConfigToRawDungeonConfigAdapter : RawDungeonConfig
	{
		private class RawDungeonImplement : RawDungeon
		{
			private DailyChallengeConfig.Dungeon dungeon;

			public RawDungeonImplement(DailyChallengeConfig.Dungeon dungeon)
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

		private DailyChallengeConfig config;

		public DailyChallengeConfigToRawDungeonConfigAdapter(DailyChallengeConfig config)
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
