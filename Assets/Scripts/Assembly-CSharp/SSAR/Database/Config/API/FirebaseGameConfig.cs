using System;
using System.Collections.Generic;
using Firebase.Database;
using Scripts.Config.Remote;

namespace Ssar.Database.Config.API
{
	public class FirebaseGameConfig
	{
		public class Meta
		{
			public bool status;

			public string version;

			public string supportedVersion;

			public Meta(bool status, string version, string supportedVersion)
			{
			}

			public Meta(Dictionary<string, object> raw)
			{
			}
		}

		private const string path_to_meta = "config/{0}/meta";

		private const string path_to_data = "config/{0}/data";

		private FirebaseDatabase database;

		public FirebaseGameConfig(FirebaseDatabase database)
		{
		}

		public void Load(string configName, ConfigVersion version, Action<bool, string, ConfigVersion, string> callback)
		{
		}

		private void ReadMeta(string configName, Action<bool, Meta> callback)
		{
		}

		private void ReadData(string configName, Action<bool, string> callback)
		{
		}
	}
}
