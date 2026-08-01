using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class DungeonConfigToRawDungeonConfigAdapter : RawDungeonConfig
	{
		private DungeonConfig dc;

		public DungeonConfigToRawDungeonConfigAdapter(DungeonConfig dc)
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
