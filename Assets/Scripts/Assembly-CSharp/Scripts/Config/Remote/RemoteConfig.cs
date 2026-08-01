using System;

namespace Scripts.Config.Remote
{
	public interface RemoteConfig
	{
		void ReadConfigVersion(Action<bool, ConfigVersion> resultCallback);

		void DownloadConfig(Action<bool, ConfigVersion, string, int> progressCallback);

		void SaveAllDownloadedConfigUnderVersion(ConfigVersion versionValue);
	}
}
