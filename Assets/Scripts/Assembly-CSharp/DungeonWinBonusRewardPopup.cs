using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DungeonWinBonusRewardPopup : BasePopup
{
	[CompilerGenerated]
	private sealed class _003CDelayActive_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DungeonWinBonusRewardPopup _003C_003E4__this;

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
		public _003CDelayActive_003Ed__10(int _003C_003E1__state)
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

	public GameObject btn_close;

	public GameObject btn_skip;

	public GameObject wg_activeSkip;

	public GameObject btn_x2;

	public TweenScale tweenAlpha;

	public UITable table;

	private List<RewardItemView> rewardItemViews;

	private List<ItemInfo> reward;

	protected override void Awake()
	{
	}

	public void Show(List<ItemInfo> rewards)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayActive_003Ed__10))]
	private IEnumerator DelayActive()
	{
		return null;
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	private void Skip(GameObject o)
	{
	}

	private void UpdateSkipIcon()
	{
	}

	private void Init()
	{
	}

	private void UpdateRewward()
	{
	}

	private void Claim(GameObject o)
	{
	}

	public void OnReceiveX2()
	{
	}
}
