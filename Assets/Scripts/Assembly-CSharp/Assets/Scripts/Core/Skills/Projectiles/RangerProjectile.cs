using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Core.Skills.Projectiles
{
	public class RangerProjectile : Projectile
	{
		public RangerProjectile(Character character, Skill skill, Collision collision, Collider collider)
			: base(null, null, null, null, 0f, 0f)
		{
		}

		protected internal override Collider GetCollider()
		{
			return null;
		}

		protected internal override List<Character> PickInterestedOnesFrom(List<Character> collidedCharacters)
		{
			return null;
		}

		protected internal override void UpdateTrajectory(float dt)
		{
		}

		protected internal override bool IsFinish()
		{
			return false;
		}

		protected override void OnDestroy()
		{
		}

		public override Vector3 Position()
		{
			return default(Vector3);
		}

		public override Vector3 Velocity()
		{
			return default(Vector3);
		}

		public override Quaternion Rotation()
		{
			return default(Quaternion);
		}

		public override void SetVelocity(Vector3 velocity)
		{
		}

		public override void SetPosition(Vector3 newPosition)
		{
		}

		public override void SetTrajectory(Trajectory newTrajectory)
		{
		}

		public override Trajectory GetTrajectory()
		{
			return null;
		}
	}
}
