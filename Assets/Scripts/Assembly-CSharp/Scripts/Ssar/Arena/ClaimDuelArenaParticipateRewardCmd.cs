using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Scripts.Ssar.Arena
{
	public class ClaimDuelArenaParticipateRewardCmd : Command
	{
		[Inject]
		public int participate { get; set; }

		[Inject]
		public OnClaimDuelArenaParticipateRewardSignal OnClaimDuelArenaParticipateRewardSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
