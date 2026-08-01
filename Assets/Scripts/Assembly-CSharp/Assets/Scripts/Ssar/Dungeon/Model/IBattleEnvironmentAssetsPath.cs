using Assets.Scripts.Config;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Dungeon.Model
{
	public interface IBattleEnvironmentAssetsPath
	{
		string CameraPath();

		string TerrainPath();

		string TerrainColliderPath();

		string PrefabConfigMonsterSpawnPath();

		string StageCameraPath();

		string EnvironmentInfluenecConfigPath();

		Assets.Scripts.Ssar.Dungeon.Configs.DungeonConfig DungeonConfigAdapter(ConfigManager configManager, DungeonConfigInspector dungeonConfigInspector);
	}
}
