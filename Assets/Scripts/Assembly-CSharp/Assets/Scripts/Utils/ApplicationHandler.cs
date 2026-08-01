using System;
using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class ApplicationHandler : MonoBehaviour
	{
		public static ApplicationHandler instance;

		private Action onQuit;

		private Action onPause;

		private Action onBack;

		private Action onResume;

		private bool enableCatchException;

		private Action<ExceptionInfo> exception;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void LogCallback(string condition, string stackTrace, LogType type)
		{
		}

		public void EnableCatchException(bool enable)
		{
		}

		public void ListenException(Action<ExceptionInfo> exception)
		{
		}

		public void UnListenException(Action<ExceptionInfo> exception)
		{
		}

		public void ListenOnQuit(Action action)
		{
		}

		public void ListenOnPause(Action action)
		{
		}

		public void UnListenOnQuit(Action action)
		{
		}

		public void UnListenOnPause(Action action)
		{
		}

		public void ListenOnBack(Action action)
		{
		}

		public void UnListenOnBack(Action action)
		{
		}

		public void ListenToResume(Action action)
		{
		}

		public void UnlistenToResume(Action action)
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void Update()
		{
		}
	}
}
