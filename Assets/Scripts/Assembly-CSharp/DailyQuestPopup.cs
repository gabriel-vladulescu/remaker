using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ssar.DailyQuest.View;
using UnityEngine;

public class DailyQuestPopup : BasePopup
{
	[CompilerGenerated]
	private sealed class _003CUpdateDataRoutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyQuestPopup _003C_003E4__this;

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
		public _003CUpdateDataRoutine_003Ed__21(int _003C_003E1__state)
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

	public SimpleWrapContent table;

	public GameObject anchor;

	public UIScrollView ScrollView;

	public GameObject btn_close;

	public GameObject masterQuestContainer;

	public GameObject wg_reset;

	public GameObject btn_unavailableReset;

	private List<DailyQuestRowView> rowViews;

	private MasterQuestView masterQuestView;

	private Action onClose;

	private ButtonWatchAds buttonWatchAds;

	protected override void Awake()
	{
	}

	protected override void onEnable()
	{
	}

	public void Show(Action onClose)
	{
	}

	public void UpdateData()
	{
	}

	private void UpdateMasterQuest()
	{
	}

	private new void Hide(GameObject o)
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	private void UnavailableReset(GameObject go)
	{
	}

	private void InitRow()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateDataRoutine_003Ed__21))]
	private IEnumerator UpdateDataRoutine()
	{
		return null;
	}

	private void InitMasterQuest()
	{
	}
}
