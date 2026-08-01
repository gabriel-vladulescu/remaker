using Assets.Scripts.Config;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public class RaidBossEnvironmentAssetsPath : IBattleEnvironmentAssetsPath
	{
		private RaidBossConfig.Room roomInfo;

		public RaidBossEnvironmentAssetsPath(RaidBossConfig.Room roomInfo)
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

		public Vector3 SpawnPosition()
		{
			return default(Vector3);
		}

		private string MapConfigFolder()
		{
			return null;
		}
	}
}
