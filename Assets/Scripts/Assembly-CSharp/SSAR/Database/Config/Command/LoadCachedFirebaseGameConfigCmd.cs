using Scripts.Config.Remote;
using strange.extensions.command.impl;

namespace Ssar.Database.Config.Command
{
	public class LoadCachedFirebaseGameConfigCmd : strange.extensions.command.impl.Command
	{
		public override void Execute()
		{
		}

		private bool IsValidVersion(string configName, ConfigVersion localVersion)
		{
			return false;
		}

		private string LoadData(string configName)
		{
			return null;
		}
	}
}
