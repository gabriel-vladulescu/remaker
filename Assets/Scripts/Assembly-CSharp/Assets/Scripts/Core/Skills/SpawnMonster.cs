using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class SpawnMonster
	{
		private string monsterId;

		private int monsterCount;

		private float interval;

		private float xAxisAmplitude;

		private int xAxisDensity;

		private float yAxisAmplitude;

		private int yAxisDensity;

		private Vector2 offsetPosition;

		private CoordinateOrigin coordinateOrigin;

		private float padding;

		private int onSpawnMovementType;

		private float onSpawnJumpDurationReachMaxHeight;

		private float onSpawnJumpDurationLandGround;

		private float onSpawnJumpHeight;

		private GameObject minionVfxPrefab;

		private float spawnDelay;

		private float suicideAfterSeconds;

		public string MonsterId => null;

		public int MonsterCount => 0;

		public float Interval => 0f;

		public float XAxisAmplitude => 0f;

		public int XAxisDensity => 0;

		public float YAxisAmplitude => 0f;

		public int YAxisDensity => 0;

		public Vector2 OffsetPosition => default(Vector2);

		public CoordinateOrigin CoordinateOrigin => default(CoordinateOrigin);

		public float Padding => 0f;

		public int OnSpawnMovementType => 0;

		public float OnSpawnJumpDurationReachMaxHeight => 0f;

		public float OnSpawnJumpDurationLandGround => 0f;

		public float OnSpawnJumpHeight => 0f;

		public GameObject MinionVfxPrefab => null;

		public float SpawnDelay
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SuicideAfterSeconds => 0f;

		public SpawnMonster(string monsterId, int monsterCount, float interval, float xAxisAmplitude, int xAxisDensity, float yAxisAmplitude, int yAxisDensity, Vector2 offsetPosition, CoordinateOrigin coordinateOrigin, float padding, int onSpawnMovementType, float onSpawnJumpDurationReachMaxHeight, float onSpawnJumpDurationLandGround, float onSpawnJumpHeight, GameObject minionVfxPrefab, float spawnDelay, float suicideAfterSeconds)
		{
		}

		public void SetOffsetPosition(Vector2 pos)
		{
		}

		public void SetCoordinateOrigin(CoordinateOrigin coordinateOrigin)
		{
		}
	}
}
