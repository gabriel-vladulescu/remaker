using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class UnEquipEquipmentCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public AbsUnEquipItemLogic logic { get; set; }

		public override void Execute()
		{
		}
	}
}
