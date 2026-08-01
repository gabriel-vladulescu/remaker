using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets.Scripts.Ssar.DailyLogin.View
{
	public class DailyLoginDayView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DailyLoginDayView _003C_003E4__this;

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
			public _003CDelay_003Ed__20(int _003C_003E1__state)
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

		public UISprite sp_icon;

		public UILabel lb_day;

		public UILabel lb_name;

		public UIWidget wg_claimed;

		public UIWidget wg_canClaim;

		public UIWidget wg_now;

		private UIWidget bound;

		private DailyLoginGift gift;

		private ParticleRunAroundFx particleRunAroundFx;

		private ParticleSystem particleSystem;

		private bool firstTime;

		protected virtual void Awake()
		{
		}

		public virtual void Show(DailyLoginGift gift)
		{
		}

		public virtual void Hide()
		{
		}

		private bool CanClaim()
		{
			return false;
		}

		private bool HasClaimed()
		{
			return false;
		}

		private bool IsTodayReward()
		{
			return false;
		}

		private DailyLoginData DailyLoginData()
		{
			return null;
		}

		private void ClickClaim(GameObject o)
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__20))]
		private IEnumerator Delay()
		{
			return null;
		}
	}
}
