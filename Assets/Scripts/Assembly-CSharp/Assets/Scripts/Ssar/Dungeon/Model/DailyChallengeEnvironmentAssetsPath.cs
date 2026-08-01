using Assets.Scripts.Config;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class DailyChallengeEnvironmentAssetsPath : IBattleEnvironmentAssetsPath
	{
		private DailyChallengeConfig.Dungeon dungeon;

		public DailyChallengeEnvironmentAssetsPath(DailyChallengeConfig.Dungeon dungeon)
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

		private string MapConfigFolder()
		{
			return null;
		}
	}
}
