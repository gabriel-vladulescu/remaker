using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Entry
{
	public class StartCommand : strange.extensions.command.impl.Command
	{
		[Inject]
		public FinishSetupSubSystemsSignal FinishSetupSubSystemsSignal { get; set; }

		[Inject]
		public InitDataManagerSignal InitDataManagerSignal { get; set; }

		public override void Execute()
		{
		}

		private void SetupDefaultSystem()
		{
		}

		private void BindSubSystems()
		{
		}
	}
}
