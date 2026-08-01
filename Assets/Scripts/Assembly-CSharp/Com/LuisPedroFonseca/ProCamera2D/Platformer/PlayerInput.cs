using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.Platformer
{
	[RequireComponent(typeof(CharacterController))]
	public class PlayerInput : MonoBehaviour
	{
		public Transform Body;

		public float gravity;

		public float runSpeed;

		public float acceleration;

		public float jumpHeight;

		public int jumpsAllowed;

		private float currentSpeed;

		private Vector3 amountToMove;

		private int totalJumps;

		private CharacterController _characterController;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private float IncrementTowards(float n, float target, float a)
		{
			return 0f;
		}
	}
}
