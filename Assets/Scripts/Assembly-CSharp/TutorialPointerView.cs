using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialPointerView : TutorialPopup
{
	private class ChangeMeshData
	{
		public bool isUseCircleMesh;

		public bool anchorWidthSize;
	}

	[CompilerGenerated]
	private sealed class _003CDelayActive_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialPointerView _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDelayActive_003Ed__27(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const float DELAY = 0.1f;

	private const float DELAY_BETWEEN_TWO_CLICK = 0.3f;

	public GameObject btn_touch;

	public Camera cameraUI;

	public Camera camera3D;

	public UISprite circle;

	public GameObject point;

	public GameObject icon_hand;

	public GameObject icon_handReverse;

	public GameObject circle_particle;

	public UILabel[] lb_tap;

	public ParticleRunAroundFx particleRunAroundFx;

	private GameObject mesh;

	public GameObject quad;

	public GameObject meshCircle;

	private float time;

	private bool isDrag;

	private ChangeMeshData changeMeshData;

	private GameObject clone;

	private GameObject objHasTouchDown;

	private float timeClick;

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnShow()
	{
	}

	private void BackButton()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayActive_003Ed__27))]
	private IEnumerator DelayActive()
	{
		return null;
	}

	private void SquareEffect()
	{
	}

	private void Init()
	{
	}

	private void UpdateText(PointerTutParameter pointerView)
	{
	}

	private void ActiveDragScroll(bool active)
	{
	}

	private void CloneObject()
	{
	}

	private void Update()
	{
	}

	private void EnableCollide()
	{
	}

	private void AnchorSquare(int width, int height)
	{
	}

	private UIWidget getHighestArea(GameObject o)
	{
		return null;
	}

	private void AnchorCircle(int width)
	{
	}

	private void AnchorCircleParticle()
	{
	}

	private void AnchorSprite(UISprite sp, GameObject target, int width, int height)
	{
	}

	private void AnchorMesh(GameObject mesh)
	{
	}

	protected override void OnDrag(GameObject o)
	{
	}

	protected override void OnPress(GameObject o, bool press)
	{
	}

	protected override void OnClick(GameObject o)
	{
	}

	private ChangeMeshData GetChangeMeshData()
	{
		return null;
	}

	private int GetWidth()
	{
		return 0;
	}

	private int GetHeight()
	{
		return 0;
	}
}
