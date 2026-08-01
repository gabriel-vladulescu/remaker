using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class LoadRaidGlobalProgressCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public LoadRaidGlobalProgressParameter Parameter { get; set; }

		[Inject]
		public OnLoadRaidGlobalProgressSuccessSignal SuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
