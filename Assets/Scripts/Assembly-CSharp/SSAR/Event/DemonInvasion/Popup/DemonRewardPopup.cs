using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ssar.Event.DemonInvasion.View;
using UnityEngine;

namespace Ssar.Event.DemonInvasion.Popup
{
	public class DemonRewardPopup : BasePopup
	{
		[CompilerGenerated]
		private sealed class _003CDoneUnlockDemonPass_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float time;

			public DemonRewardPopup _003C_003E4__this;

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
			public _003CDoneUnlockDemonPass_003Ed__20(int _003C_003E1__state)
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

		public GameObject btn_mainDemonPopup;

		public GameObject btn_demonPass;

		public GameObject btn_exit;

		public GameObject btn_shop;

		public GameObject btn_hack;

		public GameObject lockDemonPass;

		public UILabel lb_token;

		public GameObject Sprite2D;

		public ParticleSystem vfxUnlockDemonpass;

		[SerializeField]
		private DemonRewardItemView view;

		private List<DemonRewardItemView> itemViews;

		protected override void Awake()
		{
		}

		private void InstantiateItemView()
		{
		}

		private void GotoMainDemonPopup(GameObject go)
		{
		}

		private void GotoShopPopup(GameObject go)
		{
		}

		private void GotoDemonPassPopup(GameObject go)
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show()
		{
		}

		private void UpdateIdleFbx()
		{
		}

		public void UpdateFirstUnlockDemon()
		{
		}

		[IteratorStateMachine(typeof(_003CDoneUnlockDemonPass_003Ed__20))]
		private IEnumerator DoneUnlockDemonPass(float time)
		{
			return null;
		}

		private void UpdateReward()
		{
		}

		public void UpdateToken()
		{
		}

		public void UpdateSprite2D(bool enable)
		{
		}

		private void EnableAllBoxcollider(bool enable)
		{
		}
	}
}
