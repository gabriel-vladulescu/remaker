using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.Equipment.Model;
using Ssar.Achievement;
using Ssar.DailyQuest;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class AddRewardFromItemInfoCmd : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action<EquipmentCollectData> action;

			public EquipmentCollectData equipmentCollectData;

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
			public _003CDelay_003Ed__18(int _003C_003E1__state)
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

		private Queue<ItemInfo> queue;

		private List<ItemInfo> ret;

		[Inject]
		public AddRewardParameter Parameter { get; set; }

		[Inject]
		public DailyQuestLogic dql { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		public override void Execute()
		{
		}

		public void Notify()
		{
		}

		private void Receive(ItemInfo itemInfo, Action<ICollectData> callBack, bool disableWhenFinish)
		{
		}

		private void AddReward(ItemInfo itemInfo, out ItemInfo ret)
		{
			ret = null;
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__18))]
		private IEnumerator Delay(Action<EquipmentCollectData> action, EquipmentCollectData equipmentCollectData)
		{
			return null;
		}

		private int Comparer(ItemInfo a, ItemInfo b)
		{
			return 0;
		}

		private int GetPriority(ItemType type)
		{
			return 0;
		}
	}
}
