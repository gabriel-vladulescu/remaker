using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class AddAwakenEquipmentMaterialCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public IItem EquipmentCollectData { get; set; }

		[Inject]
		public OnAddAwakenEquipmentMaterialSignal OnAddAwakenEquipmentMaterialSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
