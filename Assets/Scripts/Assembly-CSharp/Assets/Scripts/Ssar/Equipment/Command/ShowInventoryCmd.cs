using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class ShowInventoryCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ShowInventoryParameter parameter { get; set; }

		public override void Execute()
		{
		}
	}
}
