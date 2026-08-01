using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShopPurchaseConfirmPopup : BasePopup
{
	[CompilerGenerated]
	private sealed class _003CDelay_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShopPurchaseConfirmPopup _003C_003E4__this;

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
		public _003CDelay_003Ed__19(int _003C_003E1__state)
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

	public UISprite sp_currency;

	public UILabel lb_title;

	public UILabel lb_price;

	public UITable table_price;

	public UITable table_desc;

	public UILabel lb_desc;

	public UILabel lb_buttonConfirm;

	public UIWidget icon_offset;

	public GameObject btn_cancel;

	public GameObject btn_purchase;

	public UIWidget widgetContainer;

	public UIPlayTween PlayTween;

	public GameObject container_icon;

	public UITable table;

	private Action confirm;

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

	public void Show(ShowShopPurchaseConfirmPopupParameter Parameter, Action confirm)
	{
	}

	[IteratorStateMachine(typeof(_003CDelay_003Ed__19))]
	private IEnumerator Delay()
	{
		return null;
	}

	private void TitleAndPrice(ShowShopPurchaseConfirmPopupParameter parameter)
	{
	}

	private void Icon(ShowShopPurchaseConfirmPopupParameter parameter)
	{
	}

	private void CurrencyIcon(ShowShopPurchaseConfirmPopupParameter parameter)
	{
	}

	private void Confirm(GameObject o)
	{
	}
}
