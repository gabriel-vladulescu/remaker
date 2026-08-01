using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Common.System;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Main.Command
{
	public class ShowMainScenePopupCmd : BaseShowPopupCmd
	{
		[CompilerGenerated]
		private sealed class _003CSetPlaytestBtnClick_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CSetPlaytestBtnClick_003Ed__9(int _003C_003E1__state)
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

		[Inject]
		public Metric metric { get; set; }

		[Inject(/*Could not decode attribute arguments.*/)]
		public DefaultSystem defaultSystem { get; set; }

		public override void Execute()
		{
		}

		[IteratorStateMachine(typeof(_003CSetPlaytestBtnClick_003Ed__9))]
		private IEnumerator SetPlaytestBtnClick()
		{
			return null;
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}

		public string UpdateCharacterMainBg()
		{
			return null;
		}
	}
}
