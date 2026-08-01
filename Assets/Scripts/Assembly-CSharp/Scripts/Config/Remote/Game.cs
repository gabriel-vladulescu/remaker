namespace Scripts.Config.Remote
{
	public interface Game
	{
		void ContinueUsingLocalConfig();

		void ReloadLocalConfigThenContinue();

		void StopLoading();

		void PauseLoading();

		void Quit();

		void ShowConfigDownloadingProgress(ConfigVersion version, string configName, int percent);
	}
}
