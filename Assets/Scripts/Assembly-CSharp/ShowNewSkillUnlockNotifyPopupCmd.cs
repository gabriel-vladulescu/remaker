public class ShowNewSkillUnlockNotifyPopupCmd : BaseShowPopupCmd
{
	[Inject]
	public ShowPopupNotifyParameter Parameter { get; set; }

	public override void Execute()
	{
	}

	public void Notify()
	{
	}

	protected override string GetAssetPath()
	{
		return null;
	}

	protected override string GetInjectName()
	{
		return null;
	}

	protected override PopupCamera GetCamera()
	{
		return default(PopupCamera);
	}
}
