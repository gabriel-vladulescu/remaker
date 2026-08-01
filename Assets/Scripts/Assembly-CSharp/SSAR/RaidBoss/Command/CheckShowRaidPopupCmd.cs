using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.BattleSystem.System.Arena.Api;
using Scripts.Config;
using Ssar.Analytics.Metrics;
using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class CheckShowRaidPopupCmd : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CShowStartNewSeasonPopup_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CheckShowRaidPopupCmd _003C_003E4__this;

			public RaidSeasonRankData currentRank;

			public RaidSeasonRankData previousRank;

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
			public _003CShowStartNewSeasonPopup_003Ed__25(int _003C_003E1__state)
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
		public Metric metric { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void LoadSeasonData()
		{
		}

		private void HasLoadSeasonData()
		{
		}

		private void GetUserProgress()
		{
		}

		private void HasLoadUserProgress()
		{
		}

		private void JoinSeason()
		{
		}

		private void SendJoinSeason()
		{
		}

		private void OnJoinSeasonSuccess()
		{
		}

		private void OnLoadedRankData()
		{
		}

		private void OnLoadedSeasonalRewardStatus()
		{
		}

		private bool IsJoinedSeason()
		{
			return false;
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

		private void ShowStartNewSeason()
		{
		}

		[IteratorStateMachine(typeof(_003CShowStartNewSeasonPopup_003Ed__25))]
		private IEnumerator ShowStartNewSeasonPopup(RaidSeasonRankData currentRank, RaidSeasonRankData previousRank)
		{
			return null;
		}

		private void JoinRaidMetric()
		{
		}
	}
}
