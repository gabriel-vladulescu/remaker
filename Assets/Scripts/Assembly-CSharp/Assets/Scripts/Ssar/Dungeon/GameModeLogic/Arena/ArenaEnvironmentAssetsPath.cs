using Assets.Scripts.Config;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.Model;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.GameModeLogic.Arena
{
	public class ArenaEnvironmentAssetsPath : IBattleEnvironmentAssetsPath
	{
		private readonly ArenaDungeonInfo _arenaDungeonInfo;

		private readonly global::Scripts.Config.Stage _stage;

		public ArenaEnvironmentAssetsPath(ArenaDungeonInfo arenaDungeonInfo, global::Scripts.Config.Stage stage)
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

		public Vector3 HeroSpawnPosition()
		{
			return default(Vector3);
		}

		public Vector3 EnemySpawnPosition()
		{
			return default(Vector3);
		}

		private string GetAdventureModenMainCamera()
		{
			return null;
		}

		private string GetAdventureEnvironmentInfluenceConfig()
		{
			return null;
		}

		private string GetAdventureModeTerrain()
		{
			return null;
		}

		private string GetAdventureModeColliderBoundaries()
		{
			return null;
		}

		private string GetDungeonStageCameraConfig()
		{
			return null;
		}

		private string MapConfigFolder()
		{
			return null;
		}

		private string GetAdventureModeStageConfig()
		{
			return null;
		}
	}
}
