using Assets.Scripts.Config;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class TestLevelDesignBattleEnvironmentAssetsPath : IBattleEnvironmentAssetsPath
	{
		private IDungeonInfo dungeon;

		public TestLevelDesignBattleEnvironmentAssetsPath(IDungeonInfo dungeon)
		{
		}

		public string CameraPath()
		{
			return null;
		}

		public string TerrainPath()
		{
			return null;
		}

		public string TerrainColliderPath()
		{
			return null;
		}

		public string PrefabConfigMonsterSpawnPath()
		{
			return null;
		}

		public string StageCameraPath()
		{
			return null;
		}

		public string EnvironmentInfluenecConfigPath()
		{
			return null;
		}

		public Assets.Scripts.Ssar.Dungeon.Configs.DungeonConfig DungeonConfigAdapter(ConfigManager configManager, DungeonConfigInspector dungeonConfigInspector)
		{
			return null;
		}
	}
}
