using System;
using UnityEngine;

public class FacebookDataSelectionPopup : BasePopup
{
	public UserDataPreview userDataLeft;

	public UserDataPreview userDataRight;

	public GameObject btn_no;

	public GameObject btn_yes;

	public UILabel lb_title;

	public UILabel lb_content;

	public UILabel lb_available;

	public UITable table;

	public UILabel lb_buttonRight;

	public UILabel lb_buttonLeft;

	private ShowFacebookDataSelectionParameter parameter;

	private bool saveLoadAvailable;

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

	public void Show(ShowFacebookDataSelectionParameter parameter)
	{
	}

	private int DailySavingAvailable(bool isSave, ShowFacebookDataSelectionParameter parameter)
	{
		return 0;
	}

	private void No(GameObject o)
	{
	}

	private void Yes(GameObject o)
	{
	}

	private void ShowConfirm(Action action, bool isLoadFromCloud)
	{
	}
}
