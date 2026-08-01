using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Mastery
{
	public class TrainAllMasteryCmd : Command
	{
		[Inject]
		public MasteryInfo MasteryInfo { get; set; }

		[Inject]
		public OnTrainAllMasterySuccessSignal OnTrainAllMasterySuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
