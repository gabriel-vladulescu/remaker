using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using UnityEngine;

namespace Scripts.Config.Remote
{
	public class DefaultServerStatus : ServerStatus
	{
		private class ReadAction
		{
			[CompilerGenerated]
			private sealed class _003CDownloadFile_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public ReadAction _003C_003E4__this;

				public Action<bool, ServerStatusValue> resultCallback;

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
				public _003CDownloadFile_003Ed__8(int _003C_003E1__state)
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
			private sealed class _003CWaitForTimeout_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public ReadAction _003C_003E4__this;

				public Action<bool, ServerStatusValue> resultCallback;

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
				public _003CWaitForTimeout_003Ed__7(int _003C_003E1__state)
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

			private const int timeOutInSeconds = 5;

			private string pathToServerStatus;

			private RoutineRunner routineRunner;

			private bool isTimeout;

			private bool isRead;

			public ReadAction(string pathToServerStatus, RoutineRunner routineRunner)
			{
			}

			public void Perform(Action<bool, ServerStatusValue> resultCallback)
			{
			}

			[IteratorStateMachine(typeof(_003CWaitForTimeout_003Ed__7))]
			private IEnumerator WaitForTimeout(Action<bool, ServerStatusValue> resultCallback)
			{
				return null;
			}

			[IteratorStateMachine(typeof(_003CDownloadFile_003Ed__8))]
			private IEnumerator DownloadFile(Action<bool, ServerStatusValue> resultCallback)
			{
				return null;
			}
		}

		public class ServerStatusModel
		{
			public Config config { get; set; }

			public ServerStatusValue ShowServerStatusValue()
			{
				return default(ServerStatusValue);
			}
		}

		public class Config
		{
			public string version { get; set; }

			public string status { get; set; }
		}

		private string firebaseStorageUrl;

		private readonly RoutineRunner routineRunner;

		private string pathToServerStatus;

		public DefaultServerStatus(string firebaseStorageUrl, RoutineRunner routineRunner)
		{
		}

		public void Read(Action<bool, ServerStatusValue> resultCallback)
		{
		}

		public void PrintSampleServerStatusModelToConsole()
		{
		}
	}
}
