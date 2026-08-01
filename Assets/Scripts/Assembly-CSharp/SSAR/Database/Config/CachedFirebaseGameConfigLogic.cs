namespace Ssar.Database.Config
{
	public class CachedFirebaseGameConfigLogic
	{
		private readonly string formatOfPathToCachedConfigFile;

		private readonly string formatOfPathToCachedConfigVersion;

		public bool GetConfigVersion(string configName, ref string version)
		{
			return false;
		}

		public bool GetConfigData(string configName, ref string data)
		{
			return false;
		}

		public bool SaveConfigVersion(string configName, string version)
		{
			return false;
		}

		public bool SaveConfigData(string configName, string data)
		{
			return false;
		}
	}
}
