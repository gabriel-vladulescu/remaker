using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

public class RewardReceivePopup : BasePopup
{
	[CompilerGenerated]
	private sealed class _003CUpdateIcon_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RewardReceivePopup _003C_003E4__this;

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
		public _003CUpdateIcon_003Ed__22(int _003C_003E1__state)
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

	public UILabel lb_desc;

	public UILabel lb_tier;

	public UISprite sp_icon;

	public UISprite sp_quality;

	public UISprite bg_iconSkill;

	public UISprite sp_iconSkill;

	public UIPlayTween PlayTween;

	public GameObject wgItemReward;

	public GameObject wgSkillUnlock;

	public GameObject wg_tier;

	public GameObject btn_mask;

	public UISprite sp_bg;

	private Action onHide;

	protected override void Awake()
	{
	}

	protected override void ExecuteBack()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	private void HidePopup(GameObject o)
	{
	}

	public void Show(ItemInfo itemInfo, Action onHide)
	{
	}

	public void ShowUnlockSkill(ISkillStat skillStat, Action onHide)
	{
	}

	public void NofityUnlockBloodyTower(ShowNotifyUnlockNewFeatureParameter parameter)
	{
	}

	private void UpdateData(ItemInfo itemInfo)
	{
	}

	private void ForceUpdateIcon()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateIcon_003Ed__22))]
	private IEnumerator UpdateIcon()
	{
		return null;
	}

	private new void Hide(GameObject o)
	{
	}
}
