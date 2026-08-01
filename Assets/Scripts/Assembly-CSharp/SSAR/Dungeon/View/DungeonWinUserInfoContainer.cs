using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.Dungeon.Model;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Dungeon.View
{
	public class DungeonWinUserInfoContainer : MonoBehaviour
	{
		private class ExpBar
		{
			[CompilerGenerated]
			private sealed class _003CRaiseExp_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public float from;

				public float duration;

				public float to;

				public ExpBar _003C_003E4__this;

				private float _003Cvalue_003E5__2;

				private float _003Cdelta_003E5__3;

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
				public _003CRaiseExp_003Ed__12(int _003C_003E1__state)
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
			private sealed class _003CRaiseLevel_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public int fromLv;

				public float frompercent;

				public float delayStart;

				public ExpBar _003C_003E4__this;

				public int toLv;

				public float toPercent;

				private int _003Clevel_003E5__2;

				private float _003Cexp_003E5__3;

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
				public _003CRaiseLevel_003Ed__11(int _003C_003E1__state)
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

			private float duration;

			private const float TWEEN_DELTA_TIME = 0.02f;

			private Action<int> onLevelUp;

			private Action<float> updateProgress;

			private Action finishl;

			private Action onStart;

			private int groupId;

			private int subId;

			private HeroConfig heroConfig;

			private bool hasInvokeStart;

			public ExpBar(DungeonWinUserInfoContainer monoBehaviour, Action<int> onLevelUp, Action<float> updateProgress, Action onStart, Action finish, int fromLevel, int toLevel, float fromPercent, float toPercent, float delayStart = 0f)
			{
			}

			[IteratorStateMachine(typeof(_003CRaiseLevel_003Ed__11))]
			private IEnumerator RaiseLevel(int fromLv, int toLv, float frompercent, float toPercent, float delayStart = 0f)
			{
				return null;
			}

			[IteratorStateMachine(typeof(_003CRaiseExp_003Ed__12))]
			private IEnumerator RaiseExp(float from, float to, float duration)
			{
				return null;
			}

			private void Start()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CAddBonusSoulIE_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonWinUserInfoContainer _003C_003E4__this;

			public int soul;

			private float _003Cdelta_003E5__2;

			private float _003Cduration_003E5__3;

			private float _003Ct_003E5__4;

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
			public _003CAddBonusSoulIE_003Ed__33(int _003C_003E1__state)
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

		public UILabel lb_level;

		public UILabel lb_name;

		public ProgressBarTwoColor expBar;

		public UILabel expPercent;

		public UILabel lb_battleTime;

		public UILabel lb_damageTaken;

		public UILabel lb_soul;

		public UILabel lb_soulBonus;

		public GameObject soulBonusContainer;

		public TweenAlpha tweenLevelUp;

		public TweenAlpha expBonus;

		public GameObject wg_doubleExp;

		public TweenPosition TweenPosition;

		public AnimationCurve tweenBonusExpFromWatchVod;

		private float baseProgress;

		private int lv;

		private DungeonWinParameter parameter;

		private MainCharacterData mainCharacter;

		public MainCharacterData MainCharacter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public void Hide()
		{
		}

		public void Show(DungeonWinParameter parameter)
		{
		}

		public void AddBonusExp(int exp)
		{
		}

		public void AddBonusSoul(int soul)
		{
		}

		private ExpBar GenerateBaseExpBar(DungeonWinParameter parameter, Action onFinish)
		{
			return null;
		}

		private ExpBar GenerateTotalExpBar(DungeonWinParameter parameter, Action onFinish)
		{
			return null;
		}

		private ExpBar GenerateExpBarBonusReward(DungeonWinParameter parameter, int bonus, Action onFinish)
		{
			return null;
		}

		public void SetStartExp(int lv, float expPercent)
		{
		}

		private void ShowLevel(int lv)
		{
		}

		private void ShowExp(float val)
		{
		}

		private void PlayEffectLevelUp()
		{
		}

		[IteratorStateMachine(typeof(_003CAddBonusSoulIE_003Ed__33))]
		private IEnumerator AddBonusSoulIE(int soul)
		{
			return null;
		}

		private void UpdateTextBonusSoul(int val)
		{
		}
	}
}
