using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace SSAR.BattleSystem.Collision
{
	public class SuperGround
	{
		private class GroundHit
		{
			public Vector3 point { get; private set; }

			public Vector3 normal { get; private set; }

			public float distance { get; private set; }

			public GroundHit(Vector3 point, Vector3 normal, float distance)
			{
			}
		}

		private LayerMask walkable;

		private SuperCharacterController controller;

		private GroundHit primaryGround;

		private GroundHit nearGround;

		private GroundHit farGround;

		private GroundHit stepGround;

		private GroundHit flushGround;

		private const float groundingUpperBoundAngle = 60f;

		private const float groundingMaxPercentFromCenter = 0.85f;

		private const float groundingMinPercentFromcenter = 0.5f;

		public SuperCollisionType superCollisionType { get; private set; }

		public Transform transform { get; private set; }

		public SuperGround(LayerMask walkable, SuperCharacterController controller)
		{
		}

		public void ProbeGround(Vector3 origin, int iter)
		{
		}

		private void ResetGrounds()
		{
		}

		public bool IsGrounded(float distance)
		{
			return false;
		}

		public bool IsGrounded(float distance, out Vector3 groundNormal)
		{
			groundNormal = default(Vector3);
			return false;
		}

		private bool OnSteadyGround(Vector3 normal, Vector3 point)
		{
			return false;
		}

		public Vector3 PrimaryNormal()
		{
			return default(Vector3);
		}

		public Vector3 Normal(bool isGrounded, float distance)
		{
			return default(Vector3);
		}

		public float HitDistance()
		{
			return 0f;
		}

		public float Distance()
		{
			return 0f;
		}

		public void DebugGround(bool primary, bool near, bool far, bool flush, bool step)
		{
		}

		private bool SimulateSphereCast(Vector3 groundNormal, out RaycastHit hit)
		{
			hit = default(RaycastHit);
			return false;
		}
	}
}
