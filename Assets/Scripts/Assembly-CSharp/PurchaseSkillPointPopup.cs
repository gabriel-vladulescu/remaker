using SSAR.View;
using Scripts.Config;
using UnityEngine;

public class PurchaseSkillPointPopup : BasePopup
{
	public UILabel lb_expandLevel;

	public UILabel lb_cost;

	public GameObject btn_close;

	public GameObject btn_expand;

	public GameObject wg_currencyModifier;

	public UITable table_cost;

	private int currentExpandIncrease;

	private CurrencyModifierContainer currencyModifierContainer;

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

	public void OnPurchaseSucees(int skillPoint)
	{
	}

	private void OnChangeValue(int value)
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

	private void Expand(GameObject o)
	{
	}

	private GameConfigConstant GetGameConfigConstant()
	{
		return null;
	}

	private void InitCurrencyModifier()
	{
	}
}
