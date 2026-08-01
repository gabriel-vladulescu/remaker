using Scripts.Config;

namespace Assets.Scripts.Config
{
	public class BloodyTowerConfigToRawDungeonConfigAdapter : RawDungeonConfig
	{
		private class RawDungeonImpl : RawDungeon
		{
			private BloodyTowerFloorInfo btfi;

			private int[] stageIds;

			public RawDungeonImpl(BloodyTowerFloorInfo btfi)
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

		private BloodyTowerConfig btc;

		public BloodyTowerConfigToRawDungeonConfigAdapter(BloodyTowerConfig btc)
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
