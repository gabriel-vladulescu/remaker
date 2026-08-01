using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class FirstAnniversaryLoginDayView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FirstAnniversaryLoginDayView _003C_003E4__this;

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
			public _003CDelay_003Ed__21(int _003C_003E1__state)
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

		public UISprite sp_bg;

		public UILabel lb_day;

		public UILabel lb_name;

		public UIWidget wg_claimed;

		public UIWidget wg_canClaim;

		private LoginRewardInfo dayReward;

		private ILoginDayLogic loginDayLogic;

		private UIWidget bound;

		private ParticleRunAroundFx particleRunAroundFx;

		private ParticleSystem particleSystem;

		private bool firstTime;

		private void Awake()
		{
		}

		public void Init(ILoginDayLogic loginDayLogic)
		{
		}

		public void Show(LoginRewardInfo loginReward)
		{
		}

		public void Hide()
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

		private void ClickClaim(GameObject o)
		{
		}

		private void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__21))]
		private IEnumerator Delay()
		{
			return null;
		}

		private static EquipmentConfigId GenerateEquipment(int configId)
		{
			return null;
		}
	}
}
