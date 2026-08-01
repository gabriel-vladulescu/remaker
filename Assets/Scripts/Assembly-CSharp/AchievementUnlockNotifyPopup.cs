using System;

public class AchievementUnlockNotifyPopup : BasePopup
{
	public UISprite sp_icon;

	public UILabel lb_text;

	public UIPlayTween PlayTween;

	public UIWidget wg;

	private Action onFinish;

	private bool manualDisable;

	protected override void Awake()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(QuestUnlockNotifyParameter parameter, Action action)
	{
	}

	public override bool AddToListShow()
	{
		return false;
	}
}
