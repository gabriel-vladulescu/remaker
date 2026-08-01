using Ssar.RaidBoss.Model;
using strange.extensions.mediation.impl;

namespace Ssar.RaidBoss.View
{
	public class RaidUserInfoPopupMediator : Mediator
	{
		[Inject]
		public ReshowRaidUserInfoPopupSignal ReshowRaidUserInfoPopupSignal { get; set; }

		public override void OnRegister()
		{
		}

		public override void OnRemove()
		{
		}

		private void OnDestroy()
		{
		}

		private void Reshow()
		{
		}
	}
}
