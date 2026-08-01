using Assets.Scripts.Ssar.Equipment.Command;
using Assets.Scripts.Ssar.Pet.View;
using SSAR.Equipment.View;
using UnityEngine;

public class EquipmentPreviewPopup : BasePopup
{
	public GameObject container;

	public GameObject btnClick;

	private EquipmentInfoContainer equipmentInfoContainer;

	private PetInfoContainer petInfoContainer;

	private ShowEquipmentPreviewParameter parameter;

	private new void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	private void Init()
	{
	}

	public void Show(ShowEquipmentPreviewParameter parameter)
	{
	}

	private void ClickOk(GameObject o)
	{
	}

	private void Close()
	{
	}
}
