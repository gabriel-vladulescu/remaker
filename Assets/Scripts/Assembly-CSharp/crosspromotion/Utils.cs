using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace crosspromotion
{
	public static class Utils
	{
		[CompilerGenerated]
		private sealed class _003CCheckInternetConnectionIE_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public Action<bool> action;

			private WWW _003Cwww_003E5__2;

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
			public _003CCheckInternetConnectionIE_003Ed__3(int _003C_003E1__state)
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

		public static bool checkPackageAppIsPresent(string package)
		{
			return false;
		}

		public static bool HasInstalledFbApp()
		{
			return false;
		}

		public static void CheckInternetConnection(Action<bool> action, string url = "http://google.com")
		{
		}

		[IteratorStateMachine(typeof(_003CCheckInternetConnectionIE_003Ed__3))]
		public static IEnumerator CheckInternetConnectionIE(Action<bool> action, string url = "http://google.com")
		{
			return null;
		}

		public static string GetValueFromUrl(string url, string parameterId)
		{
			return null;
		}
	}
}
