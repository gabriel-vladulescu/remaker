using UnityEngine;

namespace ProBuilder2.Examples
{
	public class CameraControls : MonoBehaviour
	{
		private const string INPUT_MOUSE_SCROLLWHEEL = "Mouse ScrollWheel";

		private const string INPUT_MOUSE_X = "Mouse X";

		private const string INPUT_MOUSE_Y = "Mouse Y";

		private const float MIN_CAM_DISTANCE = 10f;

		private const float MAX_CAM_DISTANCE = 40f;

		[Range(2f, 15f)]
		public float orbitSpeed;

		[Range(0.3f, 2f)]
		public float zoomSpeed;

		private float distance;

		public float idleRotation;

		private Vector2 dir;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
