using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using Ssar.DailyChallenge.Command;
using UnityEngine;

namespace Ssar.DailyChallenge.View
{
	public class ChallengeSelectBuffPopup : BasePopup
	{
		[CompilerGenerated]
		private sealed class _003CPlayHideFx_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ChallengeSelectBuffPopup _003C_003E4__this;

			public DailyChallengeConfig.Buff buff;

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
			public _003CPlayHideFx_003Ed__25(int _003C_003E1__state)
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

		[Header("Frames")]
		public int playAtFrame;

		public int tweenBlackMaskDuration;

		public int tweenTextDuration;

		public int tweenRuneDuration;

		public int tweenRune1AtFrame;

		public int tweenRune2AtFrame;

		public int tweenRune3AtFrame;

		public int delayHide;

		[Header("Contents")]
		public TweenAlpha blackMask;

		public TweenAlpha tweenText;

		public UILabel lb_time;

		[Header("Layout")]
		public UIGrid grid;

		public GameObject[] runeContainer;

		private List<ChallengeBuffView> buffViews;

		private List<DailyChallengeConfig.Buff> buffInfos;

		private float duration;

		private bool hasSelect;

		private Action<int> onFinish;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void Init()
		{
		}

		private void LoadBuffInfos(int[] buffIds)
		{
		}

		private void Update()
		{
		}

		private void AutoSelectBuff()
		{
		}

		private void SelectBuff(DailyChallengeConfig.Buff buff)
		{
		}

		[IteratorStateMachine(typeof(_003CPlayHideFx_003Ed__25))]
		private IEnumerator PlayHideFx(DailyChallengeConfig.Buff buff)
		{
			return null;
		}

		private float GetDuration(int frame)
		{
			return 0f;
		}

		private void TweenBlackMask()
		{
		}

		private void TweenText()
		{
		}

		private void TweenRune()
		{
		}

		public void Show(ChallengeSelectBuffPopupParameters parameters)
		{
		}
	}
}
