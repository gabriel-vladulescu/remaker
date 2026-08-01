using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Monster3100
{
	public class GateOfBabylonConfig
	{
		public enum Side
		{
			Front = 1,
			Behind = -1
		}

		public enum Direction
		{
			Forward = 1,
			Backward = -1
		}

		public float activateTime;

		public float delayActivateGateTime;

		public float delayProjectileTime;

		public Side gateSide;

		public Direction gateDirection;

		public Vector2 center;

		public int spawnerCount;

		public float size;

		public int projectileCount;

		public float spawnInterval;

		public float speed;
	}
}
