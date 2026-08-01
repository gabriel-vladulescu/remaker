using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class InitAchievementLogicCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public UserData userData { get; set; }

		public override void Execute()
		{
		}
	}
}
