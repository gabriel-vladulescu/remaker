using Assets.Scripts.Ssar.Signal;
using SSAR.Equipment.Enum;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class DisableEquipmentVisualCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public EquipmentType EquipmentType { get; set; }

		[Inject]
		public OnDisableEquipmentVisualSignal OnDisableEquipmentVisualSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
