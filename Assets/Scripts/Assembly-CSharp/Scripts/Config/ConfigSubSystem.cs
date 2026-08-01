using Assets.Scripts.Ssar.Common.System;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;

namespace Scripts.Config
{
	public class ConfigSubSystem : SubSystem
	{
		private RoutineRunner routineRunner;

		private ConfigManager configManager;

		public ConfigManager GetConfigManager => null;

		public ConfigSubSystem(RoutineRunner routineRunner)
		{
		}

		public void StartUp()
		{
		}

		public void ShutDown()
		{
		}

		public void ReloadWithNewConfigManager(ConfigManager newConfigManager)
		{
		}

		private ConfigManager CreateConfigManagerUsingConfigFromResources()
		{
			return null;
		}
	}
}
