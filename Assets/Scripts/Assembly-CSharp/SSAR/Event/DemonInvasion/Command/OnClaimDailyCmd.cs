using strange.extensions.command.impl;

namespace Ssar.Event.DemonInvasion.Command
{
	public class OnClaimDailyCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public bool isDemon { get; set; }

		[Inject]
		public int day { get; set; }

		public override void Execute()
		{
		}

		private void OnClaimDailySuccessSignal()
		{
		}
	}
}
