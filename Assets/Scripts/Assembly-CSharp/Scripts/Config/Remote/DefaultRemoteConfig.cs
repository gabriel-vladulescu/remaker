using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using UnityEngine;

namespace Scripts.Config.Remote
{
	public class DefaultRemoteConfig : RemoteConfig
	{
		private class DownloadAction
		{
			[CompilerGenerated]
			private sealed class _003CDownloadFile_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public string url;

				public DownloadAction _003C_003E4__this;

				public Counter counter;

				public Action<bool, ConfigVersion, string, int> progressCallback;

				public string name;

				public Action<Dictionary<string, string>> downloadCompleteCallback;

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

			private readonly string[] listOfConfigs;

			private readonly string formatOfPathToConfigFiles;

			private readonly string firebaseStorageUrl;

			private readonly ConfigVersion downloadingConfigVersion;

			private bool errorDownloading;

			private Dictionary<string, string> configContentByConfigName;

			public DownloadAction(string[] listOfConfigs, string formatOfPathToConfigFiles, string firebaseStorageUrl, ConfigVersion downloadingConfigVersion)
			{
			}

			public void Perform(Action<bool, ConfigVersion, string, int> progressCallback, Action<Dictionary<string, string>> downloadCompleteCallback)
			{
			}

			[IteratorStateMachine(typeof(_003CDownloadFile_003Ed__8))]
			private IEnumerator DownloadFile(string url, string name, Counter counter, Action<bool, ConfigVersion, string, int> progressCallback, Action<Dictionary<string, string>> downloadCompleteCallback)
			{
				return null;
			}
		}

		private class ReadAction
		{
			[CompilerGenerated]
			private sealed class _003CDownloadFile_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public ReadAction _003C_003E4__this;

				public Action<bool, ConfigVersion> resultCallback;

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
				public _003CDownloadFile_003Ed__9(int _003C_003E1__state)
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
			private sealed class _003CWaitForTimeout_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public ReadAction _003C_003E4__this;

				public Action<bool, ConfigVersion> resultCallback;

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
				public _003CWaitForTimeout_003Ed__8(int _003C_003E1__state)
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

			private string pathToVersionConstant;

			private RoutineRunner routineRunner;

			private readonly ConfigVersion localConfigVersion;

			private bool isTimeout;

			private bool isRead;

			public ReadAction(string pathToVersionConstant, RoutineRunner routineRunner, ConfigVersion localConfigVersion)
			{
			}

			public void Perform(Action<bool, ConfigVersion> resultCallback)
			{
			}

			[IteratorStateMachine(typeof(_003CWaitForTimeout_003Ed__8))]
			private IEnumerator WaitForTimeout(Action<bool, ConfigVersion> resultCallback)
			{
				return null;
			}

			[IteratorStateMachine(typeof(_003CDownloadFile_003Ed__9))]
			private IEnumerator DownloadFile(Action<bool, ConfigVersion> resultCallback)
			{
				return null;
			}
		}

		private class Counter
		{
			private int value;

			public Counter(int value)
			{
			}

			public void Increase()
			{
			}

			public int Value()
			{
				return 0;
			}
		}

		private readonly string firebaseStorageUrl;

		private readonly RoutineRunner routineRunner;

		protected readonly ConfigVersion localConfigVersion;

		private readonly string[] listOfConfigs;

		private int progress;

		private string pathToVersionConstant;

		private Dictionary<string, string> configContentByConfigName;

		public DefaultRemoteConfig()
		{
		}

		public DefaultRemoteConfig(string firebaseStorageUrl, RoutineRunner routineRunner, ConfigVersion localConfigVersion, string[] listOfConfigs)
		{
		}

		public virtual void ReadConfigVersion(Action<bool, ConfigVersion> resultCallback)
		{
		}

		public void DownloadConfig(Action<bool, ConfigVersion, string, int> progressCallback)
		{
		}

		public void SaveAllDownloadedConfigUnderVersion(ConfigVersion versionValue)
		{
		}
	}
}
