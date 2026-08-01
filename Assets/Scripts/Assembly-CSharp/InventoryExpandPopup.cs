using Scripts.Config;
using UnityEngine;

public class InventoryExpandPopup : BasePopup
{
	public UILabel lb_expandLevel;

	public UILabel lb_currentValue;

	public UILabel lb_cost;

	public UIScrollBar scrollBar;

	public GameObject btn_plus;

	public GameObject btn_minus;

	public GameObject btn_close;

	public GameObject btn_expand;

	public UITable table_cost;

	private int currentExpandIncrease;

	private int expandCost;

	private ButtonCollider buttonCollider;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show()
	{
	}

	public void UpdateData()
	{
	}

	private void ClickPlus(GameObject o)
	{
	}

	private void ClickMinus(GameObject o)
	{
	}

	private void OnChangeScrollBar()
	{
	}

	private void UpdateExpandLevelTitle()
	{
	}

	private int CurrentMaxlevelCanIncrease()
	{
		return 0;
	}

	private int MaxExpandLevel()
	{
		return 0;
	}

	private InventoryExpandConfig Config()
	{
		return null;
	}

	private void Expand(GameObject o)
	{
	}

	private void SetButtonExpandClickable(bool clickable)
	{
	}
}
