using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class CompleteTutorialCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int id { get; set; }

		[Inject]
		public bool addReward { get; set; }

		public override void Execute()
		{
		}
	}
}
