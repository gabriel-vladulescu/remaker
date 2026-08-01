using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class AddRewardFromClaimRaidEndSeasonCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public AddRewardFromClaimRaidEndSeasonParameter Parameter { get; set; }

		public override void Execute()
		{
		}
	}
}
