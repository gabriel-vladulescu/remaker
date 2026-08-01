using System;
using SSAR.WorldMap.Enum;

namespace SSAR.WorldMap.Model
{
	[Serializable]
	public class NodeProgress
	{
		public NodeStatus status;

		public int nodeId;

		public string firstTimeClear;

		public int loseBeforeClear;

		public NodeProgress()
		{
		}

		public NodeProgress(int nodeId)
		{
		}

		public void SetNodeStatus(NodeStatus status)
		{
		}

		public NodeStatus GetNodeStatus()
		{
			return default(NodeStatus);
		}

		public void UpdateLose()
		{
		}

		public bool IsCleared()
		{
			return false;
		}
	}
}
