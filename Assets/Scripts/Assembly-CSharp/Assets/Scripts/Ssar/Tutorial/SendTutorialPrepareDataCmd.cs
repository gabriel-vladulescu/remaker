using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Tutorial
{
	public class SendTutorialPrepareDataCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int groupId { get; set; }

		public override void Execute()
		{
		}
	}
}
