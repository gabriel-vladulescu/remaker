using System.Collections.Generic;
using SSAR.View;
using Scripts.Config;
using UnityEngine;

public class ChangeDisplayNamePopup : BasePopup
{
	public UIInput input;

	public GameObject btn_confirm;

	public GameObject btn_dice;

	public UILabel nameArray;

	private ShowChangeDisplayNameParameter parameter;

	private List<RandomDisplayFirstNameValue> firstNames;

	private List<RandomDisplayLastNameValue> lastNames;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(ShowChangeDisplayNameParameter parameter)
	{
	}

	public void Click(GameObject o)
	{
	}

	private void RandomName(GameObject o)
	{
	}
}
