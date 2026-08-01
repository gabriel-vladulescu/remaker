using Assets.Scripts.Config;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.Model;
using UnityEngine;

public class DungeonConfigCacheData
{
	private GameObject dungeonVisual;

	private DungeonConfig dungeonConfig;

	private MapColliderBoundariesConfig dungeonColliderConfig;

	private MovementInfluenceByEnvironmentConfig movementInfluenceByEnvironmentConfig;

	private GameObject dungeonCameraConfig;

	private GameObject mainCamera;

	private DungeonConfigInspector dungeonConfigInspector;

	public void CacheDungeonTerrain(GameObject o)
	{
	}

	public void CacheDungeonConfig(DungeonConfig dungeonConfig)
	{
	}

	public void CacheDungeonMainCamera(GameObject o)
	{
	}

	public void CacheDungeonColliderConfig(MapColliderBoundariesConfig collider)
	{
	}

	public void CacheDungeonStageCamera(GameObject o)
	{
	}

	public void CacheMovementInfluenceByEnvirnomentConfig(MovementInfluenceByEnvironmentConfig config)
	{
	}

	public void CacheDungeonConfigInspector(DungeonConfigInspector dungeonConfigInspector)
	{
	}

	public DungeonConfig GetDungeonConfig()
	{
		return null;
	}

	public GameObject GetDungeonTerrain()
	{
		return null;
	}

	public MapColliderBoundariesConfig GetDungeonTerrainCollider()
	{
		return null;
	}

	public GameObject GetDungeonStageCamera()
	{
		return null;
	}

	public GameObject GetDungeonMainCamera()
	{
		return null;
	}

	public MovementInfluenceByEnvironmentConfig GetMovementInfluenceByEnvironmentConfig()
	{
		return null;
	}

	public DungeonConfigInspector GetDungeonConfigInspector()
	{
		return null;
	}
}
