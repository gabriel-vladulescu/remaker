using System.Collections.Generic;
using Assets.Scripts.Ssar.Equipment.Command;
using SSAR.Equipment.Enum;
using SSAR.Equipment.View;

public class RuneInventoryView : AbstractInventoryView
{
	private CollectType collectType;

	protected override void Awake()
	{
	}

	protected override void OnShowInventory(List<ICollectData> collectData, ShowInventoryParameter parameter)
	{
	}

	public override string GetRowPath()
	{
		return null;
	}

	protected override int GetNumChildOfRow()
	{
		return 0;
	}
}
