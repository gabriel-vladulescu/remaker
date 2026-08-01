namespace Scripts.Config.Remote
{
	public class DynamicConfig
	{
		private ServerStatus serverStatus;

		private MaintenancePopup maintenancePopup;

		private UpdateGameClientPopup updateGameClientPopup;

		private Game game;

		private RemoteConfig remoteConfig;

		private ConfigVersion localConfigVersion;

		private ConfigVersion remoteConfigVersionBeforeDownloading;

		public DynamicConfig(ServerStatus serverStatus, MaintenancePopup maintenancePopup, UpdateGameClientPopup updateGameClientPopup, Game game, RemoteConfig remoteConfig, ConfigVersion localConfigVersion)
		{
		}

		public void Read()
		{
		}

		private void OnReadServerStatusResult(bool success, ServerStatusValue serverStatusValue)
		{
		}

		private void OnRemoteConfigVersionReadingResult(bool success, ConfigVersion remoteConfigVersion)
		{
		}

		private void OnRemoteConfigDownloadingProgress(bool success, ConfigVersion version, string configName, int percent)
		{
		}

		private bool ShouldUpdateGameClient(ConfigVersion localConfigVersion, ConfigVersion remoteConfigVersion)
		{
			return false;
		}

		private void OnUserInteractionToMaintenancePopup(MaintenancePopupAction interaction)
		{
		}
	}
}
