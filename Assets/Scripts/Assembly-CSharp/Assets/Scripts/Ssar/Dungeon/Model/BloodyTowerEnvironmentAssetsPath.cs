using Assets.Scripts.Config;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class BloodyTowerEnvironmentAssetsPath : IBattleEnvironmentAssetsPath
	{
		private BloodyTowerFloorInfo info;

		public BloodyTowerEnvironmentAssetsPath(BloodyTowerFloorInfo floorInfo)
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

		private string GetAdventureModenMainCamera(BloodyTowerFloorInfo dungeon)
		{
			return null;
		}

		private string GetAdventureEnvironmentInfluenceConfig(BloodyTowerFloorInfo dungeon)
		{
			return null;
		}

		private string GetAdventureModeTerrain(BloodyTowerFloorInfo dungeon)
		{
			return null;
		}

		private string GetAdventureModeColliderBoundaries(BloodyTowerFloorInfo dungeon)
		{
			return null;
		}

		private string GetAdventureModeStageConfig(BloodyTowerFloorInfo dungeon)
		{
			return null;
		}

		private string GetDungeonStageCameraConfig(BloodyTowerFloorInfo dungeon)
		{
			return null;
		}

		private string MapConfigFolder(BloodyTowerFloorInfo info)
		{
			return null;
		}
	}
}
