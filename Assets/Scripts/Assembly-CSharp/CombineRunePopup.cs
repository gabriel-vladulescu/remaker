using Assets.Scripts.Ssar.Rune.View;
using SSAR.View;
using Scripts.Config;
using Ssar.Rune.Model;
using UnityEngine;

public class CombineRunePopup : BasePopup
{
	public GameObject[] wg_item;

	public GameObject wg_sell;

	public GameObject wg_currencyModifier;

	public GameObject btn_close;

	private RuneSimpleInfoView[] runeSimpleInfoView;

	private ButtonSellView buttonSellView;

	private CurrencyModifierContainer currencyModifierContainer;

	private int currentValue;

	private Rune rune;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(Rune rune)
	{
	}

	private int Max()
	{
		return 0;
	}

	private void InitItem()
	{
	}

	private void InitSell()
	{
	}

	private void InitCurrencyModifier()
	{
	}

	private void Combine()
	{
	}

	private void OnChangeValue(int value)
	{
	}

	private RuneConfig.RuneItemConfig HigherRune()
	{
		return null;
	}
}
