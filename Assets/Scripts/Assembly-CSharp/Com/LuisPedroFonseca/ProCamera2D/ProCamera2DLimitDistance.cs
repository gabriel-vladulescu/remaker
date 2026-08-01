using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	[HelpURL("http://www.procamera2d.com/user-guide/extension-limit-distance/")]
	public class ProCamera2DLimitDistance : BasePC2D, IPositionDeltaChanger
	{
		public static string ExtensionName;

		public bool LimitHorizontalCameraDistance;

		public float MaxHorizontalTargetDistance;

		public bool LimitVerticalCameraDistance;

		public float MaxVerticalTargetDistance;

		private int _pdcOrder;

		public int PDCOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		public Vector3 AdjustDelta(float deltaTime, Vector3 originalDelta)
		{
			return default(Vector3);
		}
	}
}
