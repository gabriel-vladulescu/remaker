using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Dungeon.Command;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class DuelArenaLosePopup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CChampionWinStarEffect_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DuelArenaLosePopup _003C_003E4__this;

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
			public _003CChampionWinStarEffect_003Ed__34(int _003C_003E1__state)
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
		private sealed class _003CDisappear_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DuelArenaWinStarView star;

			public DuelArenaLosePopup _003C_003E4__this;

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
			public _003CDisappear_003Ed__32(int _003C_003E1__state)
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
		private sealed class _003CRankDownFx_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DuelArenaLosePopup _003C_003E4__this;

			public ArenaResultData arenaLoseData;

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
			public _003CRankDownFx_003Ed__33(int _003C_003E1__state)
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
		private sealed class _003CStartEffect_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DuelArenaLosePopup _003C_003E4__this;

			public ArenaResultData arenaLoseData;

			public float delayPlayFx;

			private int _003Ci_003E5__2;

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
			public _003CStartEffect_003Ed__31(int _003C_003E1__state)
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

		private GameObject rankdownFx;

		public GameObject mask;

		public GameObject btn_exit;

		public GameObject wgCantDropStar;

		public GameObject btn_protect;

		public UILabel lb_tip;

		public UILabel lb_battleTime;

		[Header("Fx")]
		public float delayPlayFx;

		public float delayDisappearStarAfterLightUp;

		public float disappearStarFxDuration;

		public float rankDownFxDuration;

		public float delayPlayDownRankFxAfterDisappearStar;

		private DuelArenaWinStarView[] DuelArenaWinStarViews;

		private bool enableExit;

		private GameObject rankUpFx;

		private GameObject bgFx;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void Show(ArenaResultData arenaLoseData, bool isFirstTime)
		{
		}

		private bool IsReplay()
		{
			return false;
		}

		private void ClickProtect(GameObject o)
		{
		}

		private void DisableProtect()
		{
		}

		private void InitStar(int starBefore)
		{
		}

		[IteratorStateMachine(typeof(_003CStartEffect_003Ed__31))]
		private IEnumerator StartEffect(ArenaResultData arenaLoseData, float delayPlayFx)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDisappear_003Ed__32))]
		private IEnumerator Disappear(DuelArenaWinStarView star)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRankDownFx_003Ed__33))]
		private IEnumerator RankDownFx(ArenaResultData arenaLoseData)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CChampionWinStarEffect_003Ed__34))]
		private IEnumerator ChampionWinStarEffect()
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
