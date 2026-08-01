using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class CheckEnterBloodyTowerFloorCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public int floor { get; set; }

		public override void Execute()
		{
		}

		private bool IsInventoryFull()
		{
			return false;
		}
	}
}
