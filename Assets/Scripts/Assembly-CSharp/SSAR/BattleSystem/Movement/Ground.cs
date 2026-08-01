using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	[SerializeField]
	public struct Ground
	{
		public RaycastHit hit { get; set; }

		public RaycastHit nearHit { get; set; }

		public RaycastHit farHit { get; set; }

		public RaycastHit secondaryHit { get; set; }

		public SuperCollisionType collisionType { get; set; }

		public Transform transform { get; set; }

		public Ground(RaycastHit hit, RaycastHit nearHit, RaycastHit farHit, RaycastHit secondaryHit, SuperCollisionType superCollisionType, Transform hitTransform)
		{
			this.hit = default(RaycastHit);
			this.nearHit = default(RaycastHit);
			this.farHit = default(RaycastHit);
			this.secondaryHit = default(RaycastHit);
			collisionType = null;
			transform = null;
		}
	}
}
