using strange.extensions.command.impl;

namespace Scripts.Ssar.Arena
{
	public class AddRewardFromClaimArenaEndSeasonCmd : Command
	{
		[Inject]
		public ArenaTier ArenaTier { get; set; }

		[Inject]
		public ArenaDivision Division { get; set; }

		[Inject]
		public int rank { get; set; }

		public override void Execute()
		{
		}
	}
}
