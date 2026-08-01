using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
	[RequireComponent(typeof(CharacterController))]
	public class PlayerInput : MonoBehaviour
	{
		public float RunSpeed;

		public float Acceleration;

		private float _currentSpeedH;

		private float _currentSpeedV;

		private Vector3 _amountToMove;

		private int _totalJumps;

		private CharacterController _characterController;

		private bool _movementAllowed;

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
