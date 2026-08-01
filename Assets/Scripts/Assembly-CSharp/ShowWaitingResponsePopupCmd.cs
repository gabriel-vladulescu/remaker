public class ShowWaitingResponsePopupCmd : BaseShowPopupCmd
{
	[Inject]
	public bool instance { get; set; }

	[Inject]
	public float minTimeToShow { get; set; }

	public override void Execute()
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
