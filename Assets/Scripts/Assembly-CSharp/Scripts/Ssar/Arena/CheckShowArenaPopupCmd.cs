using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Signal;
using SSAR.BattleSystem.System.Arena.Api;
using Ssar.Analytics.Metrics;
using strange.extensions.command.impl;

namespace Scripts.Ssar.Arena
{
	public class CheckShowArenaPopupCmd : Command
	{
		[CompilerGenerated]
		private sealed class _003CLostBattleDueDisconect_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CheckShowArenaPopupCmd _003C_003E4__this;

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
			public _003CLostBattleDueDisconect_003Ed__30(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CShowStartNewSeasonPopup_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CheckShowArenaPopupCmd _003C_003E4__this;

			public RankData currentRank;

			public RankData previousRank;

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
			public _003CShowStartNewSeasonPopup_003Ed__22(int _003C_003E1__state)
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

		private GetUserSeasonProgressesAndRewardStatusResult getProgressResult;

		[Inject]
		public ArenaJoinNewSeasonSignal ArenaJoinNewSeasonSignal { get; set; }

		[Inject]
		public ShowArenaPreparationPopupSignal ShowArenaPreparationPopupSignal { get; set; }

		[Inject]
		public Metric metric { get; set; }

		public override void Execute()
		{
		}

		private void New()
		{
		}

		private void HasLoadSeasonInfo()
		{
		}

		private void GetUserProgress()
		{
		}

		private void HasLoadProgress()
		{
		}

		private void JointSeason()
		{
		}

		private void JoinSeasonSuccess(MainCharacterData mcd, ArenaJoinNewSeasonCallBack callBack)
		{
		}

		private void ShowStartNewSeason(GetUserSeasonProgressesAndRewardStatusResult result)
		{
		}

		private void UpdateRankReward(GetUserSeasonProgressesAndRewardStatusResult result)
		{
		}

		[IteratorStateMachine(typeof(_003CShowStartNewSeasonPopup_003Ed__22))]
		private IEnumerator ShowStartNewSeasonPopup(RankData currentRank, RankData previousRank)
		{
			return null;
		}

		private bool AnotherSeasonStart()
		{
			return false;
		}

		private void ShowLoading()
		{
		}

		private void HideLoading()
		{
		}

		private void ShowError(StatusCode code, string message, Action ac = null)
		{
		}

		private void ShowPopup()
		{
		}

		private void CheckSendResulLastBattle()
		{
		}

		private MainCharacterData GetMainCharacterData()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLostBattleDueDisconect_003Ed__30))]
		private IEnumerator LostBattleDueDisconect()
		{
			return null;
		}
	}
}
