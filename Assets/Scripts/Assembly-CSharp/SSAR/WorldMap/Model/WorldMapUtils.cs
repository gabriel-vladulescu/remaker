using System.Collections.Generic;
using Assets.Scripts.Ssar.StarChest;
using SSAR.Equipment.Enum;
using SSAR.Equipment.View;
using SSAR.WorldMap.Enum;
using Scripts.Config;
using Ssar.Analytics.Metrics;

namespace SSAR.WorldMap.Model
{
	public static class WorldMapUtils
	{
		private class Comparer : CollectDataComparer
		{
			protected override int onCompare(ICollectData x, ICollectData y)
			{
				return 0;
			}

			private int GetPoint(EquipmentType type)
			{
				return 0;
			}
		}

		private static Dictionary<int, List<EquipmentConfigId>> cacheDungeonDrop;

		public static bool CanMoveNextRegion(int currentMapId, ScenarioDifficulty difficulty, DungeonConfig config)
		{
			return false;
		}

		public static bool CanMovePreviousRegion(int currentMapId, ScenarioDifficulty difficulty, DungeonConfig config)
		{
			return false;
		}

		public static List<EquipmentConfigId> GetListRewardCanReceive(int nodeId)
		{
			return null;
		}

		public static bool NextNodeIsValid(int currentNodeId, WorldMapData worldMapData, DungeonConfig dungeonConfig)
		{
			return false;
		}

		public static bool NodeIsValid(int nodeId, WorldMapData worldMapData, DungeonConfig dungeonConfig)
		{
			return false;
		}

		public static int GetNextNodeId(int currentNodeId, DungeonConfig dungeonConfig)
		{
			return 0;
		}

		public static int GetStaminaRequireToEnterNode(int nodeId, DungeonConfig dungeonConfig)
		{
			return 0;
		}

		public static bool IsLockedByConfigConstant(int nodeId)
		{
			return false;
		}

		public static ScenarioDifficulty GetHighestDifficultyPlayable(DungeonConfig dungeonConfig)
		{
			return default(ScenarioDifficulty);
		}

		public static int GetNodeStart()
		{
			return 0;
		}

		public static bool ParseToNodeId(string nodeIdString, out int nodeID)
		{
			nodeID = default(int);
			return false;
		}

		public static string ParseNodeIdToString(int nodeId, DungeonConfig dungeonConfig)
		{
			return null;
		}

		private static bool MapIsValid(int mapId, ScenarioDifficulty difficulty, DungeonConfig config)
		{
			return false;
		}

		public static int GetStarCollectedOfMap(WorldMapData worldMapData, DungeonConfig dungeonConfig, int mapId, ScenarioDifficulty difficulty)
		{
			return 0;
		}

		public static int GetTotalStarCollected(WorldMapData worldMapData)
		{
			return 0;
		}

		public static StarChestStatus GetStarChestStatus(WorldMapData worldMapData, DungeonConfig dungeonConfig, ScenarioStarChestRewardInfo rewardInfo)
		{
			return default(StarChestStatus);
		}

		public static void ClearDungeonAndUnLockNextDungeon(int node, int star, WorldMapData worldMapData, Metric metric, DungeonConfig dungeonConfig)
		{
		}

		public static void UpdateLoseProgress(int node, WorldMapData worldMapData, DungeonConfig dungeonConfig)
		{
		}

		public static NodeStatus StarToStatus(int star)
		{
			return default(NodeStatus);
		}

		public static int StatusToStar(NodeStatus status)
		{
			return 0;
		}
	}
}
