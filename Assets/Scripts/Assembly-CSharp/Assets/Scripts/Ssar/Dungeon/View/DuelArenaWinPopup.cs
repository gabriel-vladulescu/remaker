using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Dungeon.Command;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class DuelArenaWinPopup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CChampionWinStarEffect_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DuelArenaWinPopup _003C_003E4__this;

			public bool isFirstTime;

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
			public _003CChampionWinStarEffect_003Ed__31(int _003C_003E1__state)
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
		private sealed class _003CNormalWinstarEffect_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DuelArenaWinPopup _003C_003E4__this;

			public ArenaResultData arenaWinData;

			public float delayPlayFx;

			private int _003Ci_003E5__2;

			private DuelArenaWinStarView _003Cstar_003E5__3;

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
			public _003CNormalWinstarEffect_003Ed__29(int _003C_003E1__state)
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
		private sealed class _003CRankUpFx_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DuelArenaWinPopup _003C_003E4__this;

			public ArenaResultData arenaWinData;

			public int starRemain;

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
			public _003CRankUpFx_003Ed__30(int _003C_003E1__state)
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

		public UISprite sp_tier;

		public UISprite sp_division;

		public UILabel lb_division;

		public UILabel lb_tier;

		public GameObject container_starAndIcon;

		public TweenScale tweenShow;

		public GameObject[] starContainer;

		public GameObject rankUpfxContainer;

		public GameObject mask;

		public GameObject wgWinStreak;

		public GameObject btn_exit;

		public UILabel lb_battleTime;

		private GameObject rankUpFx;

		private GameObject bgFx;

		[Header("Fx")]
		public float delayPlayFx;

		public float oldStartLightUpDuration;

		public float newStartLightUpDuration;

		public float delayDisappearStarAfterLightUp;

		public float delayAppearStarAfterLightUp;

		public float appearStarFxDuration;

		public float delayPlayRankupFx;

		public float rankUpFxDuration;

		public bool enableExit;

		private DuelArenaWinStarView[] DuelArenaWinStarViews;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Show(ArenaResultData arenaWinData, bool isFirstTime = true)
		{
		}

		private void InitStar(int starBefore)
		{
		}

		[IteratorStateMachine(typeof(_003CNormalWinstarEffect_003Ed__29))]
		private IEnumerator NormalWinstarEffect(ArenaResultData arenaWinData, float delayPlayFx)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRankUpFx_003Ed__30))]
		private IEnumerator RankUpFx(ArenaResultData arenaWinData, int starRemain)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CChampionWinStarEffect_003Ed__31))]
		private IEnumerator ChampionWinStarEffect(ArenaResultData winData, bool isFirstTime)
		{
			return null;
		}

		private void Update()
		{
		}

		private void InitStarPrefab()
		{
		}
	}
}
