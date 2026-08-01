using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class ShopTreasureCardView : AbsShopCardView
	{
		[CompilerGenerated]
		private sealed class _003CUpdateTimeRoutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShopTreasureCardView _003C_003E4__this;

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
			public _003CUpdateTimeRoutine_003Ed__18(int _003C_003E1__state)
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

		public UILabel lb_time;

		public UILabel lb_name;

		public UILabel lb_cost;

		public UILabel lb_bonus;

		public UILabel lb_rarity;

		public UILabel lb_guaranteed;

		public UISprite[] sp_icon;

		public UISprite sp_cost;

		public UITable table_cost;

		public GameObject btn_purchase;

		private BoxCollider btn_purchaseCollider;

		private GameObject icon_parent;

		private ShopTreasureProductInfo productInfo;

		private bool canBuy;

		private Coroutine updateTimeRoutine;

		private void Awake()
		{
		}

		public void Show(int index, ShopTreasureProductInfo productInfo)
		{
		}

		private void UpdateVideo(ShopTreasureProductInfo productInfo)
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateTimeRoutine_003Ed__18))]
		private IEnumerator UpdateTimeRoutine()
		{
			return null;
		}

		private void UpdateButtonBuyValue(bool canBuy)
		{
		}

		private bool IsFreeEquipmentAvailable(DateTime lastTime)
		{
			return false;
		}

		private void UpdatePrice(ShopTreasureProductInfo productInfo)
		{
		}

		public void Hide()
		{
		}

		private string GetIcon(ShopTreasureProductInfo shopTreasureProductInfo)
		{
			return null;
		}

		private string GetGuaranteTitle(ShopTreasureProductInfo shopTreasureProductInfo)
		{
			return null;
		}

		private void Buy(GameObject o)
		{
		}
	}
}
