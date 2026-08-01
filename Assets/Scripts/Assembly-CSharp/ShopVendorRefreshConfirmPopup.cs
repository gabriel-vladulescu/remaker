using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShopVendorRefreshConfirmPopup : BasePopup
{
	[CompilerGenerated]
	private sealed class _003CDelay_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopVendorRefreshConfirmPopup _003C_003E4__this;

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
		public _003CDelay_003Ed__15(int _003C_003E1__state)
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

	public UILabel lb_price;

	public UITable table_price;

	public UITable table_buttonOK;

	public GameObject btn_ok;

	public GameObject btn_cancel;

	public UIWidget widgetContainer;

	public UIPlayTween PlayTween;

	private int maxRefresh;

	private int price;

	private int remaining;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	public void Show()
	{
	}

	[IteratorStateMachine(typeof(_003CDelay_003Ed__15))]
	private IEnumerator Delay()
	{
		return null;
	}

	private void Refresh(GameObject o)
	{
	}
}
