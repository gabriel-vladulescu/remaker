using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Scripts.Config.Remote.Test
{
	public class DynamicConfigTest : MonoBehaviour
	{
		private class DefaultRemoteConfig : RemoteConfig
		{
			[CompilerGenerated]
			private sealed class _003CProgression_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public DefaultRemoteConfig _003C_003E4__this;

				public Action<bool, ConfigVersion, string, int> progressCallback;

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
				public _003CProgression_003Ed__10(int _003C_003E1__state)
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

			private MonoBehaviour monoBehaviour;

			private bool success;

			protected ConfigVersion configVersion;

			private bool downloadSuccess;

			private readonly Action<bool, int> otherProgressCallback;

			private int progress;

			public DefaultRemoteConfig()
			{
			}

			public DefaultRemoteConfig(MonoBehaviour monoBehaviour, bool success, ConfigVersion configVersion, bool downloadSuccess, Action<bool, int> otherProgressCallback)
			{
			}

			public virtual void ReadConfigVersion(Action<bool, ConfigVersion> resultCallback)
			{
			}

			public void DownloadConfig(Action<bool, ConfigVersion, string, int> progressCallback)
			{
			}

			[IteratorStateMachine(typeof(_003CProgression_003Ed__10))]
			private IEnumerator Progression(Action<bool, ConfigVersion, string, int> progressCallback)
			{
				return null;
			}

			public void SaveAllDownloadedConfigUnderVersion(ConfigVersion versionValue)
			{
			}
		}

		private class RemoteConfigFailedAt2nd : DefaultRemoteConfig
		{
			private int counter;

			public RemoteConfigFailedAt2nd(MonoBehaviour monoBehaviour, bool success, ConfigVersion configVersion, bool downloadSuccess, Action<bool, int> otherProgressCallback)
			{
			}

			public override void ReadConfigVersion(Action<bool, ConfigVersion> resultCallback)
			{
			}
		}

		private class DifferentRemoteConfigVersionAt2nd : DefaultRemoteConfig
		{
			private ConfigVersion configVersion2nd;

			private int counter;

			public DifferentRemoteConfigVersionAt2nd(MonoBehaviour monoBehaviour, bool success, ConfigVersion configVersion, bool downloadSuccess, Action<bool, int> otherProgressCallback, ConfigVersion configVersion2Nd)
			{
			}

			public override void ReadConfigVersion(Action<bool, ConfigVersion> resultCallback)
			{
			}
		}

		private enum GameAction
		{
			ContinueUsingLocalConfig = 0,
			ReloadLocalConfigThenContinue = 1,
			StopLoading = 2,
			PauseLoading = 3,
			Quit = 4,
			ShowConfigDownloadingProgress = 5
		}

		private class DefaultGame : Game
		{
			private GameAction currentAction;

			public GameAction CurrentAction => default(GameAction);

			public void ContinueUsingLocalConfig()
			{
			}

			public void ReloadLocalConfigThenContinue()
			{
			}

			public void StopLoading()
			{
			}

			public void PauseLoading()
			{
			}

			public void Quit()
			{
			}

			public void ShowConfigDownloadingProgress(ConfigVersion version, string configName, int percent)
			{
			}
		}

		private class DefaultUpdateGameClientPopup : UpdateGameClientPopup
		{
			public void Show()
			{
			}
		}

		private class DefaultMaintenancePopup : MaintenancePopup
		{
			private MaintenancePopupAction maintenancePopupAction;

			public DefaultMaintenancePopup(MaintenancePopupAction maintenancePopupAction)
			{
			}

			public void Show(Action<MaintenancePopupAction> resultCallback)
			{
			}
		}

		private class TwoRetriesThenQuitMaintenancePopup : MaintenancePopup
		{
			[CompilerGenerated]
			private sealed class _003Ca_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private object _003C_003E2__current;

				public Action<MaintenancePopupAction> resultCallback;

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
				public _003Ca_003Ed__3(int _003C_003E1__state)
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

			private MaintenancePopupAction maintenancePopupAction;

			private int counter;

			public void Show(Action<MaintenancePopupAction> resultCallback)
			{
			}

			[IteratorStateMachine(typeof(_003Ca_003Ed__3))]
			private IEnumerator a(Action<MaintenancePopupAction> resultCallback)
			{
				return null;
			}
		}

		private class DefaultServerStatus : ServerStatus
		{
			private bool success;

			private ServerStatusValue serverStatusValue;

			public DefaultServerStatus(bool success, ServerStatusValue serverStatusValue)
			{
			}

			public void Read(Action<bool, ServerStatusValue> resultCallback)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitThenInvoke_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float seconds;

			public Action action;

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
			public _003CWaitThenInvoke_003Ed__4(int _003C_003E1__state)
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

		private void Start()
		{
		}

		private void LoadNewConfig()
		{
		}

		private void DifferentRemoteConfigVersion()
		{
		}

		private void ServerAvailable_ReadRemoteConfigVersionSuccess_LocalConfigOutDate_NotRequireToUpdateClient_SuccessDownloading_FailedReadRemoteConfigVersion2nd()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenInvoke_003Ed__4))]
		private IEnumerator WaitThenInvoke(float seconds, Action action)
		{
			return null;
		}

		private void ServerAvailable_ReadRemoteConfigVersionSuccess_LocalConfigOutDate_NotRequireToUpdateClient_ErrorWhenDownloading()
		{
		}

		private void ServerAvailable_ReadRemoteConfigVersionSuccess_LocalConfigOutDate_RequireToUpdateClient()
		{
		}

		private void ServerAvailable_ReadRemoteConfigVersionSuccess_LocalConfigUpToDate()
		{
		}

		private void ServerAvailable_ReadRemoteConfigVersionFail()
		{
		}

		private void ServerMaintenanceWithTwoRetriesThenQuit()
		{
		}

		private void ServerStatusIsMaintenanceAndQuit()
		{
		}

		private void TestFailureOfServerStatusReading()
		{
		}
	}
}
