using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
	[HelpURL("http://www.procamera2d.com/user-guide/extension-pan-and-zoom/")]
	public class ProCamera2DPanAndZoom : BasePC2D, ISizeDeltaChanger, IPreMover
	{
		public static string ExtensionName;

		public bool AllowZoom;

		public float MouseZoomSpeed;

		public float PinchZoomSpeed;

		[Range(0f, 2f)]
		public float ZoomSmoothness;

		public float MaxZoomInAmount;

		public float MaxZoomOutAmount;

		public bool ZoomToInputCenter;

		private float _zoomAmount;

		private float _initialCamSize;

		private bool _zoomStarted;

		private float _origFollowSmoothnessX;

		private float _origFollowSmoothnessY;

		private float _prevZoomAmount;

		private float _zoomVelocity;

		private Vector3 _zoomPoint;

		private float _touchZoomTime;

		public bool AllowPan;

		public bool UsePanByDrag;

		[Range(0f, 1f)]
		public float StopSpeedOnDragStart;

		public Rect DraggableAreaRect;

		public Vector2 DragPanSpeedMultiplier;

		public bool UsePanByMoveToEdges;

		public Vector2 EdgesPanSpeed;

		[Range(0f, 0.99f)]
		public float HorizontalPanEdges;

		[Range(0f, 0.99f)]
		public float VerticalPanEdges;

		[HideInInspector]
		public bool ResetPrevPanPoint;

		private Vector2 _panDelta;

		private Transform _panTarget;

		private Vector3 _prevMousePosition;

		private Vector3 _prevTouchPosition;

		private bool _onMaxZoom;

		private bool _onMinZoom;

		private int _prmOrder;

		private int _sdcOrder;

		public int PrMOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int SDCOrder
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

		private void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void PreMove(float deltaTime)
		{
		}

		public float AdjustSize(float deltaTime, float originalDelta)
		{
			return 0f;
		}

		private void Pan(float deltaTime)
		{
		}

		private float Zoom(float deltaTime)
		{
			return 0f;
		}

		public void UpdateCurrentFollowSmoothness()
		{
		}

		public void CenterPanTargetOnCamera(float interpolant = 1f)
		{
		}

		private void CancelZoom()
		{
		}

		private void RestoreFollowSmoothness()
		{
		}

		private void RemoveFollowSmoothness()
		{
		}

		private bool InsideDraggableArea(Vector2 normalizedInput)
		{
			return false;
		}
	}
}
