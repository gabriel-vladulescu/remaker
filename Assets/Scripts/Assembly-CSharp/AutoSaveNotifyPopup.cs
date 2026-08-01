public class AutoSaveNotifyPopup : BasePopup
{
	public UILabel lb_text;

	public UIPlayTween PlayTween;

	private const float TIME_TO_HIDE = 3f;

	private string text;

	private TextLoading textLoading;

	private float timeToHide;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show()
	{
	}

	private void Update()
	{
	}
}
