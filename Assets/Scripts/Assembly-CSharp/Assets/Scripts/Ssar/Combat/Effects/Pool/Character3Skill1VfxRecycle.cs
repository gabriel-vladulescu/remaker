using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Effects.Pool
{
	public class Character3Skill1VfxRecycle : ParticleAutoReturnToPool
	{
		[Serializable]
		public class Controller
		{
			public GameObject animator;

			public string animationName;

			public GameObject object002;
		}

		[CompilerGenerated]
		private sealed class _003CCheckIfTimeUp_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Character3Skill1VfxRecycle _003C_003E4__this;

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
			public _003CCheckIfTimeUp_003Ed__2(int _003C_003E1__state)
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

		public List<Controller> controllers;

		protected override void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckIfTimeUp_003Ed__2))]
		private IEnumerator CheckIfTimeUp()
		{
			return null;
		}
	}
}
