using UnityEngine;

[AddComponentMenu("NGUI/Tween/Slider")]
public class TweenSlider : UITweener
{
	public float from;

	public float to;

	private UISlider slider;

	private bool mCached;

	public float Value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenSlider Begin(GameObject go, float duration, float sliderVal)
	{
		return null;
	}
}
