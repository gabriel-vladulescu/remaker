using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Tutorial;
using UnityEngine;

public class TutorialDialogView : TutorialPopup
{
	private class ShowNpcController
	{
		private static readonly float TWEEN_POSITION_DURATION;

		private GameObject model;

		private Camera cameraNpc;

		private readonly GameObject pivot;

		private string animationName;

		private NpcRequest npcRequest;

		private bool isMain;

		private bool enableMoveWhenStart;

		public ShowNpcController(NpcRequest request, Camera cameraNpc, GameObject pivot)
		{
		}

		public void UpdateNpcRequest(NpcRequest request)
		{
		}

		public void EnableMoveWhenStart()
		{
		}

		public void Active()
		{
		}

		public void Clear()
		{
		}

		public void UpdateAlpha(bool isMain)
		{
		}

		private void LoadNpc()
		{
		}

		public void CompleteDialog()
		{
		}

		private void InitNpc()
		{
		}

		private void InitPosition()
		{
		}

		private void InitScale()
		{
		}

		private void Move(GameObject model, Vector3 startPos, Vector3 targetPos, Action onfinish)
		{
		}

		private Vector3 GetPosition(GameObject model, Position p)
		{
			return default(Vector3);
		}

		private void UpdateFaceStart()
		{
		}

		private void UpdateNpcFace(GameObject model, NpcFace face)
		{
		}

		private void UpdateFace(Vector3 localEulerAngles)
		{
		}

		private float GetOffsetY(TutorialNpc npc)
		{
			return 0f;
		}

		private float GetOffsetZ(TutorialNpc npc)
		{
			return 0f;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDelayUpdate_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialDialogView _003C_003E4__this;

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
		public _003CDelayUpdate_003Ed__24(int _003C_003E1__state)
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

	public new UILabel name;

	public UILabel text;

	public TypewriterEffect typewriterEffect;

	public Camera cameraMask;

	public Camera cameraNpc;

	public TweenScale tweenChatPopup;

	public GameObject leftPivot;

	public GameObject rightPivot;

	public GameObject[] dot;

	public GameObject btn_skip;

	public GameObject btn_next;

	public UIWidget leftCircle;

	public UIWidget rightCircle;

	private bool finishTextEffect;

	private DialogTutParameter parameter;

	private TutorialNpc mainNpc;

	private Dictionary<TutorialNpc, ShowNpcController> npcControllers;

	protected override void Awake()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnEnable()
	{
	}

	private void BackButton()
	{
	}

	private void Update()
	{
	}

	protected override void OnShow()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayUpdate_003Ed__24))]
	private IEnumerator DelayUpdate()
	{
		return null;
	}

	private void Text()
	{
	}

	private void BlackMask()
	{
	}

	private void ActiveNpc(DialogTutParameter parameter)
	{
	}

	private ShowNpcController GetController(TutorialNpc npc, Dictionary<TutorialNpc, ShowNpcController> dict)
	{
		return null;
	}

	private bool SameNpc(TutorialNpc a, TutorialNpc b)
	{
		return false;
	}

	protected override void OnClick(GameObject o)
	{
	}

	private void ActiveDot(bool active)
	{
	}
}
