using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.Dungeon.Model;
using UnityEngine;
using strange.extensions.mediation.impl;

public class DungeonObjectiveItemView : View
{
	[CompilerGenerated]
	private sealed class _003CDelayPlayTween_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool delay;

		public DungeonObjectiveItemView _003C_003E4__this;

		public bool resetTween;

		public bool isComplete;

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
		public _003CDelayPlayTween_003Ed__18(int _003C_003E1__state)
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

	public Color32 colorUpdate;

	public Color32 colorCompleted;

	public UILabel lb_content;

	public TweenAlpha tweenAlpha;

	public TweenPosition tweenPosition;

	public UILabel text;

	public UISprite wgCompleted;

	private UITweener[] textTweeners;

	private DungeonObjectiveManager.StageGoal goal;

	private int oldValue;

	private bool finished;

	private float time;

	protected override void Awake()
	{
	}

	protected override void OnDisable()
	{
	}

	public void Show(DungeonObjectiveManager.StageGoal stageGoal)
	{
	}

	public void UpdateData(DungeonObjectiveManager.StageGoal stageGoal)
	{
	}

	public void Hide()
	{
	}

	private void UpdateData(int count, bool isUpdate)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayPlayTween_003Ed__18))]
	private IEnumerator DelayPlayTween(bool resetTween, bool delay, bool isComplete)
	{
		return null;
	}

	private void Update()
	{
	}
}
