using Assets.Scripts.Ssar.Dungeon.Model;
using SSAR.Dungeon.Model;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.TestLevelDesign
{
	public class OnTestLevelDesignWinLogic : IOnBattleWinLogic
	{
		private TestLevelDesignDungeonConfig dungeonConfig;

		public OnTestLevelDesignWinLogic(TestLevelDesignDungeonConfig dungeonConfig)
		{
		}

		public void OnExcute()
		{
		}

		private DungeonWinParameter GenerateDungeonWinParameter()
		{
			return null;
		}
	}
}
