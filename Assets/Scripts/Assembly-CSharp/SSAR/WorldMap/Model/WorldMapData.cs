using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.StarChest;
using SSAR.WorldMap.Enum;
using Scripts.Config;

namespace SSAR.WorldMap.Model
{
	[Serializable]
	public class WorldMapData
	{
		public Dictionary<string, NodeProgress> nodeDict;

		public List<int> starChestOpened;

		public void ValidateWithConfig(DungeonConfig dungeonConfig)
		{
		}

		public NodeProgress GetNodeProgress(int nodeId)
		{
			return null;
		}

		public NodeProgress GetHighestPlayableNode(DungeonConfig dungeonConfig)
		{
			return null;
		}

		public NodeProgress GetHighestNodeWithHigherOrSameStatus(DungeonConfig dungeonConfig, NodeStatus status)
		{
			return null;
		}

		public NodeProgress GetHighestNodeOfDifficultyWithHigherOrSameStatus(DungeonConfig dungeonConfig, ScenarioDifficulty difficulty, NodeStatus status)
		{
			return null;
		}

		public NodeProgress GetHighestPlayableNode(DungeonConfig dungeonConfig, ScenarioDifficulty difficulty)
		{
			return null;
		}

		public void UpdateNodeProgress(int nodeId, NodeStatus status)
		{
		}

		public void UpdateLoseProgress(int nodeId)
		{
		}

		public void OpenStarChest(int chestId)
		{
		}

		public StarChestStatus GetStatusChestStatus(DungeonConfig dungeonConfig, ScenarioStarChestRewardInfo chest)
		{
			return default(StarChestStatus);
		}

		public int GetTotalStarCollected()
		{
			return 0;
		}

		public bool HasCleared(int nodeId)
		{
			return false;
		}

		private void LoadDataSave()
		{
		}

		private int ComparerNode(NodeProgress a, NodeProgress b)
		{
			return 0;
		}
	}
}
