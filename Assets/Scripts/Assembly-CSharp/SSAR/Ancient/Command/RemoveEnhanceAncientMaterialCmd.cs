using Assets.Scripts.Ssar.Signal;
using SSAR.Equipment.Model;
using strange.extensions.command.impl;

namespace Ssar.Ancient.Command
{
	public class RemoveEnhanceAncientMaterialCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public EquipmentCollectData EquipmentCollectData { get; set; }

		[Inject]
		public OnRemoveEnhanceAncientMaterialSignal OnRemoveEnhanceAncientMaterialSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
