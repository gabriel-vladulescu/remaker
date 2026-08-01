using System;
using UnityEngine;

public class ButtonWatchAds : MonoBehaviour
{
	public UILabel lb_title;

	public UILabel lb_quantity;

	public GameObject btn_click;

	private int vodRequire;

	private Action onSuccess;

	private Reason reason;

	private void Awake()
	{
	}

	public void Init(string buttonName, int vodRequire, Reason reason, Action onSuccess)
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void ClickButton(GameObject o)
	{
	}
}
