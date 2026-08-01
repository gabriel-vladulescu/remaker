using Scripts.Config;
using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class CheckEnterRaidOfflineCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public RaidBossConfig.Room Room { get; set; }

		public override void Execute()
		{
		}

		private RaidTeamData GetTeamData()
		{
			return null;
		}
	}
}
