using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.Platformer
{
	[RequireComponent(typeof(SphereCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public class PlayerController : MonoBehaviour
	{
		public float PlayerSpeed;

		public MovementAxis Axis;

		private Vector3 _targetVelocity;

		private void FixedUpdate()
		{
		}
	}
}
