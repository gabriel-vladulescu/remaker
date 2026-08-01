using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class ShowRaidUserInfoCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ShowRaidUserInfoParameter parameter { get; set; }

		[Inject]
		public ShowRaidUserInfoPopupSignal ShowRaidUserInfoPopupSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
