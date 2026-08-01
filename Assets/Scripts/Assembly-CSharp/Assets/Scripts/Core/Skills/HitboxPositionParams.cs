using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class HitboxPositionParams
	{
		private CoordinateOrigin spawnAnchor;

		private Vector2 spawnPosition;

		private bool lockedByFacingDirection;

		public CoordinateOrigin SpawnAnchor => default(CoordinateOrigin);

		public Vector2 SpawnPosition => default(Vector2);

		public bool LockedByFacingDirection => false;

		public HitboxPositionParams(CoordinateOrigin spawnAnchor, Vector2 spawnPosition, bool lockedByFacingDirection)
		{
		}

		public void SetSpawnAnchor(CoordinateOrigin anchor)
		{
		}

		public void SetSpawnPosition(Vector2 position)
		{
		}
	}
}
