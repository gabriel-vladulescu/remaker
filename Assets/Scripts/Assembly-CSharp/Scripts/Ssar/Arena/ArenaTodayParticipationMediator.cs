using Assets.Scripts.Ssar.Signal;
using strange.extensions.mediation.impl;

namespace Scripts.Ssar.Arena
{
	public class ArenaTodayParticipationMediator : Mediator
	{
		[Inject]
		public ArenaTodayParticipationView view { get; set; }

		[Inject]
		public OnClaimDuelArenaParticipateRewardSignal OnClaimDuelArenaParticipateRewardSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
