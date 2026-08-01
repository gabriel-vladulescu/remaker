using System.Collections.Generic;
using SSAR.View;
using UnityEngine;

public class ChangeLanguagePopup : BasePopup
{
	public GameObject btn_close;

	public UITable table;

	private List<ChangeLanguageItemView> ItemViews;

	protected override void Awake()
	{
	}

	public void Show()
	{
	}

	private void InitItem()
	{
	}

	private new void Hide(GameObject o)
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}
}
