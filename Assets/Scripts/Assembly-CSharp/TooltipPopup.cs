public class TooltipPopup : BasePopup
{
	public UIWidget widget;

	public UILabel lb_text;

	public UISprite sp_bg;

	public UIWidget anchor;

	public UISprite[] negative;

	public UISprite[] positive;

	public UIPlayTween PlayTween;

	public TweenScale timerTween;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(ShowTooltipParameter parameter)
	{
	}
}
