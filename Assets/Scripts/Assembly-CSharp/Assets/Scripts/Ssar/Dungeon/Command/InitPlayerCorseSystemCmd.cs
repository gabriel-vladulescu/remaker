using Assets.Scripts.Ssar.Common.System.Resources;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class InitPlayerCorseSystemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ResourcesLoader ResourcesLoader { get; set; }

		[Inject]
		public ConfigManager ConfigManager { get; set; }

		public override void Execute()
		{
		}
	}
}
