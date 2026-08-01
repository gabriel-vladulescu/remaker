using System;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class SpawnMonsterConfig
	{
		public int spawnMonsterCount;

		public string spawnMonsterId;

		public float spawnXAxisAmplitude;

		public int spawnXAxisDensity;

		public float spawnYAxisAmplitude;

		public int spawnYAxisDensity;

		public Vector2 offsetPosition;

		public string coordinateOrigin;

		public float padding;

		public bool spawnDrawGizmos;

		public int onSpawnMovementType;

		public float onSpawnJumpDurationReachMaxHeight;

		public float onSpawnJumpDurationLandGround;

		public float onSpawnJumpHeight;

		[PreloadPool.PrefabPathMarker]
		public string minionVfxPrefabPath;

		public float interval;

		public float spawnDelay;

		public float suicideAfterSeconds;

		public CoordinateOrigin CoordinateOriginValue()
		{
			return default(CoordinateOrigin);
		}
	}
}
