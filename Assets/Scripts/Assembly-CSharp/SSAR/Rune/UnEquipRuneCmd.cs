using SSAR.Equipment.Model;
using strange.extensions.command.impl;

namespace Ssar.Rune
{
	public class UnEquipRuneCmd : Command
	{
		[Inject]
		public EquipmentCollectData EquipmentCollectData { get; set; }

		[Inject]
		public int slot { get; set; }

		[Inject]
		public OnUnEquipRuneSuccessSignal OnUnEquipRuneSuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
