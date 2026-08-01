using SSAR.Equipment.Model;
using Ssar.Rune;
using Ssar.Rune.Model;
using strange.extensions.command.impl;

public class EquipRuneToSlotCmd : Command
{
	[Inject]
	public EquipmentCollectData EquipmentCollectData { get; set; }

	[Inject]
	public Rune Rune { get; set; }

	[Inject]
	public OnEquipRuneSuccessSignal OnEquipRuneSuccessSignal { get; set; }

	public override void Execute()
	{
	}

	private bool HasSlotEmpty(EquipmentCollectData equipment, ref int slot)
	{
		return false;
	}
}
