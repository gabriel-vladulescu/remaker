using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Scripts.Ssar.Arena
{
	public class UpdateSeasonEndTimeCmd : Command
	{
		[Inject]
		public OnUpdateSeasonEndTimeSuccessSignal OnUpdateSeasonEndTimeSuccessSignal { get; set; }

		public override void Execute()
		{
		}

		private void GetServerTime()
		{
		}

		private void GetSeasonEndTime(long currentServerTimeMilli)
		{
		}
	}
}
