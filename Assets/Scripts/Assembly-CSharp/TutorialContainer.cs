using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialContainer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayEnable_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialStage stage;

		public TutorialContainer _003C_003E4__this;

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
		public _003CDelayEnable_003Ed__11(int _003C_003E1__state)
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

	private TutorialPopup curTut;

	public TutorialDialogView dialog;

	public TutorialPointerView pointer;

	public StencilUIPostFx StencilUiPostFx;

	private TutorialStage preStage;

	public UIWidget sp_bottom;

	public UIWidget sp_left;

	public UIWidget sp_right;

	public UIWidget sp_top;

	public void Show(TutorialStage stage)
	{
	}

	public void Hide(TutorialStage stage)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayEnable_003Ed__11))]
	private IEnumerator DelayEnable(TutorialStage stage)
	{
		return null;
	}

	protected virtual void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Anchor()
	{
	}

	private int CalculateNextPanelDepth(GameObject go)
	{
		return 0;
	}

	private UIPanel[] GetChildrenPanels(GameObject go)
	{
		return null;
	}

	public bool PreviousStageIsDialog(TutorialStage nextStage)
	{
		return false;
	}

	public void Hide()
	{
	}
}
