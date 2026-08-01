using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class ArenaConfigToRawDungeonConfigAdapter : RawDungeonConfig
	{
		private class RawDungeonImpl : RawDungeon
		{
			private ArenaDungeonInfo btfi;

			private int[] stageIds;

			public RawDungeonImpl(ArenaDungeonInfo btfi)
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

		private readonly ArenaDungeonInfo _arenaDungeonInfo;

		private readonly Stage _stage;

		public ArenaConfigToRawDungeonConfigAdapter(ArenaDungeonInfo arenaDungeonInfo, Stage stage)
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
