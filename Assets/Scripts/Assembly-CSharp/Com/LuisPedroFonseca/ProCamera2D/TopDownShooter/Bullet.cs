using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
	public class Bullet : MonoBehaviour
	{
		public float BulletDuration;

		public float BulletSpeed;

		public float SkinWidth;

		public LayerMask CollisionMask;

		public float BulletDamage;

		private Transform _transform;

		private RaycastHit _raycastHit;

		private Vector2 _collisionPoint;

		private float _startTime;

		private bool _exploding;

		private Vector3 _lastPos;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void Collide()
		{
		}

		private void Disable()
		{
		}
	}
}
