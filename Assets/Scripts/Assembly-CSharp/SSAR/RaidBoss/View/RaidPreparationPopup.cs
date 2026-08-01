using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

namespace Ssar.RaidBoss.View
{
	public class RaidPreparationPopup : BasePopup
	{
		[CompilerGenerated]
		private sealed class _003CDelayedInitData_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RaidPreparationPopup _003C_003E4__this;

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
			public _003CDelayedInitData_003Ed__23(int _003C_003E1__state)
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

		public RaidLeaderboardContainer LeaderboardContainer;

		public RaidPersonalInfoView PersonalInfoView;

		public RaidSeasonTimeLeftView SeasonTimeLeftView;

		public RaidGlobalProgressView GlobalProgressView;

		public RaidPreparationTabView[] TabViews;

		public UISprite sp_season;

		public UISprite sp_seasonBg;

		public UILabel lb_seasonName;

		public UILabel lb_refreshLeaderboard;

		public UILabel[] lb_staminaRequires;

		public GameObject resources_container;

		public GameObject btn_startOffline;

		public GameObject btn_startOnline;

		public GameObject btn_refresh;

		private RaidBossConfig.Room roomData;

		private RaidDifficulty curDifficulty;

		private float time;

		private const float DELAY = 1f;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void InitTab()
		{
		}

		private void InitResources()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedInitData_003Ed__23))]
		private IEnumerator DelayedInitData()
		{
			return null;
		}

		private void SelectTab(RaidDifficulty tabType)
		{
		}

		private void OnChangeTab(RaidDifficulty tabType)
		{
		}

		private void ShowLeaderboard(RaidDifficulty difficulty)
		{
		}

		private void OnChangeDifficulty(ScenarioDifficulty difficulty)
		{
		}

		private void StartOffline(GameObject o)
		{
		}

		private void StartOnline(GameObject o)
		{
		}

		private void RefreshLeaderBoard(GameObject o)
		{
		}

		private void Update()
		{
		}

		internal void Show()
		{
		}

		public void OnUpdateLeaderBoard()
		{
		}
	}
}
