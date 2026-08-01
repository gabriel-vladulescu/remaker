using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public class HitboxLockTargetParams
	{
		private readonly bool enabledLockTargetPosition;

		private readonly Vector2 lockTargetOffset;

		private readonly HitboxLockTargetDirection lockTargetDirection;

		public bool EnabledLockTargetPosition => false;

		public Vector2 LockTargetOffset => default(Vector2);

		public HitboxLockTargetDirection LockTargetDirection => default(HitboxLockTargetDirection);

		public HitboxLockTargetParams(bool enabledLockTargetPosition, Vector2 lockTargetOffset, HitboxLockTargetDirection lockTargetDirection)
		{
		}
	}
}
