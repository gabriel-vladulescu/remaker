using Assets.Scripts.Ssar.Rune.View;
using SSAR.View;
using Scripts.Config;
using Ssar.Rune.Model;
using UnityEngine;

public class DisassembleRunePopup : BasePopup
{
	public GameObject[] wg_item;

	public GameObject wg_currencyModifier;

	public GameObject btn_close;

	public GameObject btn_disassemble;

	private RuneSimpleInfoView[] runeSimpleInfoView;

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

	private void InitCurrencyModifier()
	{
	}

	private void Combine(GameObject o)
	{
	}

	private void OnChangeValue(int value)
	{
	}

	private RuneConfig.RuneItemConfig LowerRune()
	{
		return null;
	}
}
