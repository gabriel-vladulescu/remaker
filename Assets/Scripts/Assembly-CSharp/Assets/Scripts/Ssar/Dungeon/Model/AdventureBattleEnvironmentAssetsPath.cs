using Assets.Scripts.Config;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class AdventureBattleEnvironmentAssetsPath : IBattleEnvironmentAssetsPath
	{
		private global::Scripts.Config.Dungeon info;

		public AdventureBattleEnvironmentAssetsPath(global::Scripts.Config.Dungeon dungeon)
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

		private string GetAdventureModenMainCamera(global::Scripts.Config.Dungeon dungeon)
		{
			return null;
		}

		private string GetAdventureEnvironmentInfluenceConfig(global::Scripts.Config.Dungeon dungeon)
		{
			return null;
		}

		private string GetAdventureModeTerrain(global::Scripts.Config.Dungeon dungeon)
		{
			return null;
		}

		private string GetAdventureModeColliderBoundaries(global::Scripts.Config.Dungeon dungeon)
		{
			return null;
		}

		private string GetAdventureModeStageConfig(global::Scripts.Config.Dungeon dungeon)
		{
			return null;
		}

		private string GetDungeonStageCameraConfig(global::Scripts.Config.Dungeon dungeon)
		{
			return null;
		}

		private string MapConfigFolder(global::Scripts.Config.Dungeon dungeon)
		{
			return null;
		}
	}
}
