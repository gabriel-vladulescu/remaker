using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class AdjustAdsControllerConfigCommand : strange.extensions.command.impl.Command
	{
		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}
	}
}
