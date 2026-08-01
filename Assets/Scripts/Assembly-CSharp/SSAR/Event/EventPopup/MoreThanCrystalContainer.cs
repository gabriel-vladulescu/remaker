using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.EventPopup
{
	public class MoreThanCrystalContainer : EventContainer
	{
		[CompilerGenerated]
		private sealed class _003CTimeRemainingRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MoreThanCrystalContainer _003C_003E4__this;

			private DateTime _003CendTime_003E5__2;

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
			public _003CTimeRemainingRoutine_003Ed__11(int _003C_003E1__state)
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

		[SerializeField]
		private UILabel _timeRemaining;

		[SerializeField]
		private UIScrollView _packScroll;

		[SerializeField]
		private UITable _packTable;

		private MoreThanCrystalEventData _eventData;

		private List<MoreThanCrystalInfo> _eventInfos;

		private List<MoreThanCrystalReward> _rewardInfos;

		private EventPopupMoreThanRowView[] _packViews;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void Refresh()
		{
		}

		[IteratorStateMachine(typeof(_003CTimeRemainingRoutine_003Ed__11))]
		private IEnumerator TimeRemainingRoutine()
		{
			return null;
		}

		private void InitPackView()
		{
		}

		private void UpdatePackView()
		{
		}
	}
}
