using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Config
{
	public class RaidConfigInspector : DungeonConfigInspector
	{
		public GameObject[] CompanionSpawnPositions;

		private List<Vector3> spawnPositions;

		public Vector3 GetSpawnPositon()
		{
			return default(Vector3);
		}
	}
}
