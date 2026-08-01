using Assets.Scripts.Ssar.Signal;
using Ssar.Rune.Model;
using strange.extensions.command.impl;

namespace Assets.Scripts.Mastery
{
	public class RemoveMaterialToTrainMasteryCmd : Command
	{
		[Inject]
		public RuneType RuneType { get; set; }

		[Inject]
		public RuneRarity RuneRarity { get; set; }

		[Inject]
		public OnRemoveMaterialToTrainMasterySignal OnRemoveMaterialToTrainMasterySignal { get; set; }

		public override void Execute()
		{
		}
	}
}
