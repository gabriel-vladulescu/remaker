using UnityEngine;

namespace Assets.Scripts.Ssar.Common.Debug
{
	public class DebugLogOptions : MonoBehaviour
	{
		public static DebugLogOptions instance;

		public bool logInfo;

		public bool logWarning;

		public bool logError;

		public bool enableAllForEditorMode;

		public bool enableAllForDevelopmentBuild;

		private void Awake()
		{
		}

		public static bool IsLogEnabled()
		{
			return false;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void DoApply()
		{
		}

		public void EnableLogByConfig()
		{
		}

		private void EnableLogsWithOptions()
		{
		}

		private void EnableAllLogs()
		{
		}

		private static bool IsDevelopmentBuild()
		{
			return false;
		}

		private static bool IsEditorMode()
		{
			return false;
		}
	}
}
