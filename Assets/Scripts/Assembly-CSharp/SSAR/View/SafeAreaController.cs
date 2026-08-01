using UnityEngine;

namespace SSAR.View
{
	[ExecuteInEditMode]
	public class SafeAreaController : MonoBehaviour
	{
		public enum Mode
		{
			UIPanel = 0,
			Camera = 1
		}

		public Mode mode;

		public Rect cameraRect;

		public Vector2 panelSize;

		private static readonly Vector2[] specificSizes;

		private static readonly Rect defaultRect;

		private void Start()
		{
		}

		private void AutoScale()
		{
		}

		private void ScaleCamera()
		{
		}

		private void ScalePanel()
		{
		}

		[ContextMenu("Execute")]
		public virtual void ExecuteScale()
		{
		}
	}
}
