using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class LoadRaidGlobalRewardStatusCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public LoadRaidGlobalRewardStatusParameter Parameter { get; set; }

		[Inject]
		public OnLoadRaidGlobalRewardStatusSuccessSignal SuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
