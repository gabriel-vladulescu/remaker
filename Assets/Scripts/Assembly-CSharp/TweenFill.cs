using UnityEngine;

[RequireComponent(typeof(UIBasicSprite))]
[AddComponentMenu("NGUI/Tween/Tween Fill")]
public class TweenFill : UITweener
{
	[Range(0f, 1f)]
	public float from;

	[Range(0f, 1f)]
	public float to;

	private bool mCached;

	private UIBasicSprite mSprite;

	public float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Cache()
	{
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenFill Begin(GameObject go, float duration, float fill)
	{
		return null;
	}

	public override void SetStartToCurrentValue()
	{
	}

	public override void SetEndToCurrentValue()
	{
	}
}
