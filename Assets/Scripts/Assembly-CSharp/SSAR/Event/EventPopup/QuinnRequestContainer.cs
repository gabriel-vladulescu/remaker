using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.EventPopup
{
	public class QuinnRequestContainer : EventContainer
	{
		[CompilerGenerated]
		private sealed class _003CTimeRemainingRoutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public QuinnRequestContainer _003C_003E4__this;

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
			public _003CTimeRemainingRoutine_003Ed__16(int _003C_003E1__state)
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
		private UILabel _totalEventCoin;

		[SerializeField]
		private UILabel _timeRemaining;

		[SerializeField]
		private UIScrollView _questScroll;

		[SerializeField]
		private UIScrollView _packScroll;

		[SerializeField]
		private UITable _questTable;

		[SerializeField]
		private UITable _packTable;

		[SerializeField]
		private GameObject _coinButton;

		private QuinnRequestEventData _eventData;

		private List<DailyQuestConfig.QuestItem> _questInfos;

		private List<QuinnRequestPackInfo> _packInfos;

		private EventPopupQuestView[] _questViews;

		private EventPopupPackView[] _packViews;

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

		[IteratorStateMachine(typeof(_003CTimeRemainingRoutine_003Ed__16))]
		private IEnumerator TimeRemainingRoutine()
		{
			return null;
		}

		private void InitQuestView()
		{
		}

		private void InitPackView()
		{
		}

		private void UpdateQuestView()
		{
		}

		private void UpdatePackView()
		{
		}
	}
}
