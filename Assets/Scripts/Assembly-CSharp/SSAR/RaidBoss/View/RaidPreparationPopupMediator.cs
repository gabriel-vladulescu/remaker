using Ssar.RaidBoss.Model;
using strange.extensions.mediation.impl;

namespace Ssar.RaidBoss.View
{
	public class RaidPreparationPopupMediator : Mediator
	{
		[Inject]
		public RaidPreparationPopup view { get; set; }

		[Inject]
		public OnUpdateRaidLeaderboardSignal OnUpdateRaidLeaderboardSignal { get; set; }

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
