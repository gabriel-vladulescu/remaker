using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class AdventureWinButtonContainer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdventureWinButtonContainer _003C_003E4__this;

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
			public _003CDelay_003Ed__14(int _003C_003E1__state)
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

		public GameObject btn_retry;

		public GameObject btn_next;

		public GameObject btn_worldMap;

		public UITable table;

		private MainCharacterData mainCharacterData;

		private void Awake()
		{
		}

		public void SetActiveButton(bool active)
		{
		}

		private bool IsTutorial()
		{
			return false;
		}

		private bool NextNodeIsValid()
		{
			return false;
		}

		private void Next(GameObject o)
		{
		}

		private void Retry(GameObject o)
		{
		}

		private void EnableUI(bool enable)
		{
		}

		private void ShowNodeInfo(int nodeId)
		{
		}

		private void WorldMap(GameObject o)
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__14))]
		private IEnumerator Delay()
		{
			return null;
		}

		private DungeonConfig DungeonConfig()
		{
			return null;
		}
	}
}
