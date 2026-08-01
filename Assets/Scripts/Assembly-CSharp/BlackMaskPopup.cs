using Assets.Scripts.Ssar.Command;
using UnityEngine;

public class BlackMaskPopup : BasePopup
{
	public new AnimationCurve animationCurve;

	public GameObject tween;

	private TweenAlpha TweenAlpha;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(ShowBlackMaskParameter parameter)
	{
	}
}
