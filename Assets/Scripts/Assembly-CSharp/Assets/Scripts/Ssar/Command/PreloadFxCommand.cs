using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Common.System.Resources;
using SSAR.BattleSystem.Effect;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class PreloadFxCommand : strange.extensions.command.impl.Command
	{
		[CompilerGenerated]
		private sealed class _003CLoad_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private ResourcesSubSystem _003CsubSystem_003E5__2;

			private EffectEditorInfo[] _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

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
			public _003CLoad_003Ed__1(int _003C_003E1__state)
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

		public override void Execute()
		{
		}

		[IteratorStateMachine(typeof(_003CLoad_003Ed__1))]
		private IEnumerator Load()
		{
			return null;
		}
	}
}
