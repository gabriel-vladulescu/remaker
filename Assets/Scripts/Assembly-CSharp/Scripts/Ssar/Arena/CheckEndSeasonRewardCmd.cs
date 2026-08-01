using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Scripts.Ssar.Arena
{
	public class CheckEndSeasonRewardCmd : Command
	{
		[Inject]
		public OnCheckEndSeasonRewardSuccessSignal OnCheckEndSeasonRewardSuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
