using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	public class DollyZoomExample : MonoBehaviour
	{
		[Range(0.1f, 179.9f)]
		public float TargetFOV;

		[Range(0f, 10f)]
		public float Duration;

		public EaseType EaseType;

		[Range(-1f, 1f)]
		public float ZoomAmount;

		private void OnGUI()
		{
		}
	}
}
