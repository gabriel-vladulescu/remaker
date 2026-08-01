using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SSAR.BattleSystem.System.Arena.Api
{
	public class HttpRequest
	{
		[CompilerGenerated]
		private sealed class _003CGetText_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public HttpRequest _003C_003E4__this;

			public Action<bool, string> callback;

			private WWW _003Cwww_003E5__2;

			private float _003Ctimer_003E5__3;

			private bool _003Cfailed_003E5__4;

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
			public _003CGetText_003Ed__4(int _003C_003E1__state)
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
		private sealed class _003CPostText_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public string text;

			public HttpRequest _003C_003E4__this;

			public Action<bool, string> callback;

			private WWW _003Cwww_003E5__2;

			private float _003Ctimer_003E5__3;

			private bool _003Cfailed_003E5__4;

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
			public _003CPostText_003Ed__5(int _003C_003E1__state)
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

		private int timeout;

		public HttpRequest(int timeout)
		{
		}

		public void GetAsText(string url, Action<bool, string> callback)
		{
		}

		public void PostAsText(string url, string text, Action<bool, string> callback)
		{
		}

		[IteratorStateMachine(typeof(_003CGetText_003Ed__4))]
		private IEnumerator GetText(string url, Action<bool, string> callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPostText_003Ed__5))]
		private IEnumerator PostText(string url, string text, Action<bool, string> callback)
		{
			return null;
		}
	}
}
