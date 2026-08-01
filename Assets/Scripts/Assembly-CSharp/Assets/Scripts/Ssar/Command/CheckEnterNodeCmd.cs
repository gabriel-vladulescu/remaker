using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class CheckEnterNodeCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int nodeId { get; set; }

		public override void Execute()
		{
		}

		private bool IsInventoryFull()
		{
			return false;
		}
	}
}
