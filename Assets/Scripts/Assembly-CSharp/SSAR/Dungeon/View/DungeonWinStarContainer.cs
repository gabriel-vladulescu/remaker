using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Dungeon.View;
using SSAR.Dungeon.Model;
using UnityEngine;

namespace SSAR.Dungeon.View
{
	public class DungeonWinStarContainer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSequencePlay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DungeonWinStarContainer _003C_003E4__this;

			public int star;

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
			public _003CSequencePlay_003Ed__8(int _003C_003E1__state)
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

		public UISprite[] stars;

		public float DELAY;

		public UITable table_starCondition;

		private Action onFinish;

		private DungeonGetStarConditionView[] dungeonGetStarConditionViews;

		private DungeonWinParameter parameter;

		private void Awake()
		{
		}

		public void Show(DungeonWinParameter parameter, Action onFinish)
		{
		}

		[IteratorStateMachine(typeof(_003CSequencePlay_003Ed__8))]
		private IEnumerator SequencePlay(int star)
		{
			return null;
		}

		private void Init()
		{
		}
	}
}
