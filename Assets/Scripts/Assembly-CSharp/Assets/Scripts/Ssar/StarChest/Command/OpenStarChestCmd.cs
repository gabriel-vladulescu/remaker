using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.StarChest.Command
{
	public class OpenStarChestCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ScenarioStarChestRewardInfo RewardInfo { get; set; }

		public override void Execute()
		{
		}
	}
}
