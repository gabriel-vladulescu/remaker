using System.Collections.Generic;
using SSAR.BattleSystem.Collision;
using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class SuperCharacterController
	{
		protected struct IgnoredCollider
		{
			public Collider collider;

			public int layer;

			public IgnoredCollider(Collider collider, int layer)
			{
				this.collider = null;
				this.layer = 0;
			}
		}

		public const float Tolerance = 0.05f;

		public const float TinyTolerance = 0.01f;

		public static SuperCollisionType defaultCollisionType;

		private LayerMask Walkable;

		public Transform transform;

		private Vector3 groundOffset;

		private Vector3 lastGroundPosition;

		private List<Collider> ignoredColliders;

		private List<IgnoredCollider> ignoredColliderStack;

		private const string TemporaryLayer = "TempCast";

		private const int MaxPushbackIterations = 2;

		private int TemporaryLayerIndex;

		private ColliderConfigData colliderConfigData;

		private bool isUpdateGround;

		private bool cachedIsGrounded;

		private Collider[] _colliders;

		public SuperGround currentGround { get; private set; }

		public CollisionSphere feet { get; private set; }

		public CollisionSphere body { get; private set; }

		public CollisionSphere head { get; private set; }

		public List<SuperCollision> collisionData { get; private set; }

		public float radius => 0f;

		public float height => 0f;

		public Vector3 up => default(Vector3);

		public Vector3 down => default(Vector3);

		public SuperCharacterController(GameObject gameObject, ColliderConfigData colliderConfigData)
		{
		}

		public void UpdateLayer(int layer)
		{
		}

		public void Move(Vector3 delta)
		{
		}

		private void CheckAndValidateMaxX(ref Vector3 delta)
		{
		}

		private void CheckAndValidateMaxY(Vector3 delta)
		{
		}

		public bool IsGrounded()
		{
			return false;
		}

		public bool IsCeiling()
		{
			return false;
		}

		private void ProbeGround(int iter)
		{
		}

		private void RecursivePushback(int depth, int maxDepth)
		{
		}

		private void PushIgnoredColliders()
		{
		}

		private void PopIgnoredColliders()
		{
		}

		public Vector3 SpherePosition(CollisionSphere sphere)
		{
			return default(Vector3);
		}

		public bool PointBelowHead(Vector3 point)
		{
			return false;
		}

		public bool PointAboveFeet(Vector3 point)
		{
			return false;
		}

		public void IgnoreCollider(Collider col)
		{
		}

		public void RemoveIgnoredCollider(Collider col)
		{
		}

		public void ClearIgnoredColliders()
		{
		}

		private bool HasConfigCollision()
		{
			return false;
		}
	}
}
