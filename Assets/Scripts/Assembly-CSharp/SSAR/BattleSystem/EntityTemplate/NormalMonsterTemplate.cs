using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Artemis.Attributes;

namespace SSAR.BattleSystem.EntityTemplate
{
	[ArtemisEntityTemplate("NormalMob")]
	public class NormalMonsterTemplate : BaseMonsterTemplate
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Entity entity;

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
			public _003CDelay_003Ed__3(int _003C_003E1__state)
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

		public new const string Name = "NormalMob";

		protected override void OnBuild(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected override void Final(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__3))]
		private IEnumerator Delay(Entity entity)
		{
			return null;
		}
	}
}
