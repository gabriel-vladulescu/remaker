using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Scripts.Ssar.Arena
{
	public class ArenaSeasonTimeLeftViewMediator : Mediator
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ArenaSeasonTimeLeftViewMediator _003C_003E4__this;

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
			public _003CDelay_003Ed__34(int _003C_003E1__state)
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

		[Inject]
		public ArenaSeasonTimeLeftView ArenaSeasonTimeLeftView { get; set; }

		[Inject]
		public OnCheckEndSeasonRewardSuccessSignal OnCheckEndSeasonRewardSuccessSignal { get; set; }

		[Inject]
		public CheckEndSeasonRewardSignal CheckEndSeasonRewardSignal { get; set; }

		[Inject]
		public OnClaimEndSeasonRewardSuccessSignal OnClaimEndSeasonRewardSuccessSignal { get; set; }

		[Inject]
		public OnClaimPromotionArenaRankRewardSuccessSignal OnClaimPromotionArenaRankRewardSuccessSignal { get; set; }

		[Inject]
		public UpdateArenaTimeLeftViewSignal UpdateArenaTimeLeftViewSignal { get; set; }

		[Inject]
		public OnUpdateSeasonEndTimeSuccessSignal OnUpdateSeasonEndTimeSuccessSignal { get; set; }

		[Inject]
		public UpdateSeasonEndTimeSignal UpdateSeasonEndTimeSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnEnabled()
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__34))]
		private IEnumerator Delay()
		{
			return null;
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
