using Ssar.RaidBoss.Model;
using strange.extensions.mediation.impl;

namespace Ssar.RaidBoss.View
{
	public class RaidPersonalInfoMediator : Mediator
	{
		[Inject]
		public RaidPersonalInfoView view { get; set; }

		[Inject]
		public UpdateRaidPersonalInfoViewSignal UpdateRaidPersonalInfoViewSignal { get; set; }

		[Inject]
		public OnLoadRaidGlobalProgressSuccessSignal LoadProgressSuccessSignal { get; set; }

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
