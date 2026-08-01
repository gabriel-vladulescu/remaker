using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class AddRewardFromClaimRaidGlobalCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public AddRewardFromClaimRaidGlobalParameter Parameter { get; set; }

		public override void Execute()
		{
		}
	}
}
