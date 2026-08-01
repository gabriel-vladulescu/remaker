using SSAR.Equipment.Model;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class AutoEquipEquipmentCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IAutoEquipEquipmentParameter Parameter { get; set; }

		public override void Execute()
		{
		}

		private UISfx GetSfx(EquipmentCategory category)
		{
			return default(UISfx);
		}
	}
}
