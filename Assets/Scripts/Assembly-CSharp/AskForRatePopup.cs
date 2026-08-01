using System;
using Ssar.Analytics.Metrics.Social;
using UnityEngine;

public class AskForRatePopup : BasePopup
{
	public UIPlayTween PlayTween;

	public GameObject btn_close;

	public GameObject button_1;

	public GameObject button_5;

	public UISprite avatar;

	private Action onClose;

	protected override void Awake()
	{
	}

	private void Rate1Star(GameObject go)
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	private void Rate5Stars(GameObject go)
	{
	}

	private static void SendMetric(VoteResult result)
	{
	}

	private void Close(GameObject go)
	{
	}

	private void CloseWithoutSendMetric(GameObject go)
	{
	}

	public void Show(Action action)
	{
	}
}
