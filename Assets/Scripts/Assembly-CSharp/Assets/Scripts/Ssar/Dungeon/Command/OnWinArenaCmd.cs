using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.CharacterSelection.Model;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic.Arena;
using SSAR.BattleSystem.System.Arena.Api;
using Scripts.Config;
using Scripts.Ssar.Arena;
using Ssar.Analytics.Metrics;
using Ssar.Event.SevenDaysCampaign;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class OnWinArenaCmd : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CPlayTooltipCoro_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CPlayTooltipCoro_003Ed__21(int _003C_003E1__state)
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
		private sealed class _003CShowPopupRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public OnWinArenaCmd _003C_003E4__this;

			public ArenaResultData arenaWinData;

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
			public _003CShowPopupRoutine_003Ed__24(int _003C_003E1__state)
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

		private MainCharacterData saveData;

		[Inject]
		public ArenaModeParameter Parameter { get; set; }

		[Inject]
		public Metric metric { get; set; }

		[Inject]
		public CampaignLogic campaignLogic { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		private void SendRequest()
		{
		}

		private void AddRecord(ArenaResultData result)
		{
		}

		private void Success(UpdateDuelResultData data)
		{
		}

		[IteratorStateMachine(typeof(_003CPlayTooltipCoro_003Ed__21))]
		private IEnumerator PlayTooltipCoro()
		{
			return null;
		}

		private float PlayAnimation()
		{
			return 0f;
		}

		private void Popup(ArenaResultData arenaWinData, float delay)
		{
		}

		[IteratorStateMachine(typeof(_003CShowPopupRoutine_003Ed__24))]
		private IEnumerator ShowPopupRoutine(ArenaResultData arenaWinData, float delay)
		{
			return null;
		}

		private void ShowPopup(ArenaResultData arenaWinData)
		{
		}

		private ArenaResultData GenerateWinData(UserSeasonProgress before, UserSeasonProgress after, int rankBefore, int rank)
		{
			return null;
		}

		private void WinMetric(ArenaResultData arenaWinData)
		{
		}

		private void MatchupMetric(CharacterCode main, CharacterCode opponent)
		{
		}

		private void RankupMetric()
		{
		}

		private void UpdateFirstAnniversaryQuest()
		{
		}

		private void UpdateXmasWarQuest(DuelArenaData duelArenaData)
		{
		}

		private void UpdateCampaignQuest(ArenaResultData arenaWinData)
		{
		}
	}
}
