namespace Scripts.Config.Remote
{
	public class DefaultGame : Game
	{
		private CheckRemoteConfigVersionCommand checkRemoteConfigVersionCommand;

		public DefaultGame(CheckRemoteConfigVersionCommand checkRemoteConfigVersionCommand)
		{
		}

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
}
