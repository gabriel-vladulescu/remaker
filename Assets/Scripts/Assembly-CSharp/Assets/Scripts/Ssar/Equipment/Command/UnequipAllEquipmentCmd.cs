using Assets.Scripts.Ssar.Signal;
using SSAR.Equipment.Model;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class UnequipAllEquipmentCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IUnequipAllEquipmentParameter Parameter { get; set; }

		[Inject]
		public OnUnequipAllEquipmentSuccessSignal OnUnequipAllEquipmentSuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
