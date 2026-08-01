using Assets.Scripts.Ssar.Signal;
using SSAR.Equipment.Model;
using strange.extensions.command.impl;

namespace Ssar.Ancient.Command
{
	public class AddEnhanceAncientMaterialCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public EquipmentCollectData EquipmentCollectData { get; set; }

		[Inject]
		public OnAddEnhanceAncientMaterialSignal OnAddEnhanceAncientMaterialSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
