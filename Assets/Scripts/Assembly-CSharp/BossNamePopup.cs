using UnityEngine;

public class BossNamePopup : BasePopup
{
	public Transform startPos;

	public Transform endPos;

	public UILabel lb_name;

	public UISprite bg;

	public TweenPosition TweenPosition;

	private float delay;

	private float time;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(string name, float delay)
	{
	}

	private void Update()
	{
	}

	private void Tween()
	{
	}
}
