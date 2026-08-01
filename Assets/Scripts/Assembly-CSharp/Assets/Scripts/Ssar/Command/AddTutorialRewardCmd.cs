using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class AddTutorialRewardCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int id { get; set; }

		public override void Execute()
		{
		}
	}
}
