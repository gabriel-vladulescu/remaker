using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class SelectArenaRunePopup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPlayHideFx_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SelectArenaRunePopup _003C_003E4__this;

			public ArenaRuneInfo runeInfo;

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
			public _003CPlayHideFx_003Ed__20(int _003C_003E1__state)
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

		public int playAtFrame;

		public int tweenBlackMaskDuration;

		public int tweenTextDuration;

		public int tweenRuneDuration;

		public int tweenRune1AtFrame;

		public int tweenRune2AtFrame;

		public int tweenRune3AtFrame;

		public int delayHide;

		public TweenAlpha blackMask;

		public TweenAlpha tweenText;

		public UILabel lb_time;

		public GameObject[] runeContainer;

		private List<ArenaRuneView> arenaRuneViews;

		private Action<ArenaRuneInfo> onFinish;

		private List<ArenaRuneInfo> runeInfos;

		private float time;

		private bool hasSelect;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		private void SelectRune(ArenaRuneInfo runeInfo)
		{
		}

		[IteratorStateMachine(typeof(_003CPlayHideFx_003Ed__20))]
		private IEnumerator PlayHideFx(ArenaRuneInfo runeInfo)
		{
			return null;
		}

		private void AutoSelectRune()
		{
		}

		public void Show(Action<ArenaRuneInfo> onFinish)
		{
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

		private float GetDuration(int frame)
		{
			return 0f;
		}

		private void Update()
		{
		}

		private List<ArenaRuneInfo> PickRuneInfo()
		{
			return null;
		}

		private ArenaRuneInfo Pick(List<ArenaRuneInfo> arenaRuneInfos)
		{
			return null;
		}
	}
}
