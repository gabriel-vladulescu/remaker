using Ssar.Event.EventLogin.Model;
using strange.extensions.command.impl;

namespace Ssar.Event.EventLogin.Command
{
	public class ClaimEventLoginRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int day { get; set; }

		[Inject]
		public OnClaimEventLoginRewardSuccessSignal SuccessSignal { get; set; }

		public override void Execute()
		{
		}

		private void AddReward()
		{
		}
	}
}
