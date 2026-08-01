using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Assets.Scripts.Ssar.DynamicAssets
{
	public class DownloadAssetBundles
	{
		[CompilerGenerated]
		private sealed class _003CDoAction_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string host;

			public DownloadAssetBundles _003C_003E4__this;

			private WWW _003Cw_003E5__2;

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
			public _003CDoAction_003Ed__6(int _003C_003E1__state)
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

		private Action<AssetBundle> onFinish;

		private Action<string> onError;

		public void ListenOnFinish(Action<AssetBundle> onFinish)
		{
		}

		public void ListenOnError(Action<string> error)
		{
		}

		public void Fetch(string host)
		{
		}

		[IteratorStateMachine(typeof(_003CDoAction_003Ed__6))]
		private IEnumerator DoAction(string host)
		{
			return null;
		}

		private string FileName()
		{
			return null;
		}
	}
}
