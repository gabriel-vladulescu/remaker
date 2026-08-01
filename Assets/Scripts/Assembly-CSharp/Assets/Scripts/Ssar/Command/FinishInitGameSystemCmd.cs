using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class FinishInitGameSystemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public FinishPrepareToLoginSignal FinishPrepareToLoginSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
