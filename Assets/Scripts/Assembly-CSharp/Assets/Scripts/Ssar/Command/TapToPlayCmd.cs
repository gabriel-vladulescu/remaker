using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class TapToPlayCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ValidateUserDataSignal ValidateUserDataSignal { get; set; }

		public override void Execute()
		{
		}

		private void LoadTutorial()
		{
		}

		private void CompleteTut()
		{
		}
	}
}
