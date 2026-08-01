using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DrawShopBoughtCardView : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayIdle_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DrawShopBoughtCardView _003C_003E4__this;

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
		public _003CDelayIdle_003Ed__24(int _003C_003E1__state)
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

	public SkinnedMeshRenderer mesh;

	public GameObject joint;

	public AnimationClip clipIdle;

	public AnimationClip clipDone;

	public AnimationClip clipAction;

	public AnimationClip clipAction2;

	public float delaySetToDone;

	private Animation anim;

	private BoxCollider col;

	private ItemInfo3DCoreView core;

	private bool isOpened;

	private bool isHighGrade;

	private float duration;

	private bool useAnim2;

	private void Awake()
	{
	}

	public void Show(ItemInfo itemData, bool isHighGrade, bool useAnim2)
	{
	}

	public void Activate()
	{
	}

	public void Open()
	{
	}

	public bool IsOpened()
	{
		return false;
	}

	public bool IsHighGrade()
	{
		return false;
	}

	private void OnClick()
	{
	}

	private void EnableClick(bool value)
	{
	}

	private void SetToDone()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayIdle_003Ed__24))]
	private IEnumerator DelayIdle()
	{
		return null;
	}
}
