using Ssar.RaidBoss.Model;
using strange.extensions.command.impl;

namespace Ssar.RaidBoss.Command
{
	public class UpdateRaidSeasonEndTimeCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public OnUpdateRaidSeasonEndTimeSuccessSignal OnUpdateRaidSeasonEndTimeSuccessSignal { get; set; }

		public override void Execute()
		{
		}

		private void GetSeasonEndTime(long currentServerTimeMilli)
		{
		}
	}
}
