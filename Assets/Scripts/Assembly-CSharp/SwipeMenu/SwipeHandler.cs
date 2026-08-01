using UnityEngine;

namespace SwipeMenu
{
	public class SwipeHandler : MonoBehaviour
	{
		public bool handleSwipes;

		public bool handleFlicks;

		private Vector3 finalPosition;

		private Vector3 startpos;

		private Vector3 endpos;

		private Vector3 oldpos;

		private float length;

		private float startTime;

		private float mouseMove;

		private float force;

		private bool SW;

		public bool isSwiping => false;

		private void Update()
		{
		}

		private void HandleMobileSwipe()
		{
		}

		private void HandleMouseSwipe()
		{
		}
	}
}
