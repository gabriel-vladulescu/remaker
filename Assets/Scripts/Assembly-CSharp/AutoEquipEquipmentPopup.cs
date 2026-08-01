using SSAR.Equipment.Model;
using UnityEngine;

public class AutoEquipEquipmentPopup : BasePopup
{
	[Header("Before")]
	public UILabel lb_attack_before;

	public UILabel lb_defense_before;

	public UILabel lb_hp_before;

	[Header("After")]
	public UILabel lb_attack_after;

	public UILabel lb_defense_after;

	public UILabel lb_hp_after;

	[Header("Diff")]
	public UILabel lb_attack_diff;

	public UILabel lb_defense_diff;

	public UILabel lb_hp_diff;

	[Header("Button")]
	public GameObject btn_close;

	public GameObject btn_ok;

	private IAutoEquipEquipmentParameter parameter;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	public void Show(IAutoEquipEquipmentParameter parameter)
	{
	}

	private void SetText(UILabel labelBefore, UILabel labelAfter, UILabel diff, double before, double after)
	{
	}

	private void ClickAccept(GameObject o)
	{
	}
}
