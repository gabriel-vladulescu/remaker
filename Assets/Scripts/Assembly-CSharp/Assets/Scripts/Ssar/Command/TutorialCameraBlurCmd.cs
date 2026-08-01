using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class TutorialCameraBlurCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public bool enableBlur { get; set; }

		public override void Execute()
		{
		}
	}
}
