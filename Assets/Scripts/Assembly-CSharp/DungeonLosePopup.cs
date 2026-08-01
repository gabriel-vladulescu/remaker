using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon.Command;
using Assets.Scripts.Ssar.Dungeon.Popup;
using UnityEngine;

public class DungeonLosePopup : BasePopup
{
	private class TweenContainerController : ITweenController
	{
		private UIWidget container;

		private AnimationCurve animationCurve;

		private float time;

		private float DURATION;

		private float MAX_ALHA;

		public TweenContainerController(UIWidget container, AnimationCurve animationCurve, float duration, float maxAlpha)
		{
		}

		public void Update(float deltaTime)
		{
		}

		public bool IsFinish()
		{
			return false;
		}
	}

	private class TweenMaskController : ITweenController
	{
		private UISprite mask;

		private AnimationCurve animationCurve;

		private float time;

		private float DURATION;

		private float MAX_ALHA;

		public TweenMaskController(UISprite mask, AnimationCurve animationCurve, float duration, float maxAlpha)
		{
		}

		public void Update(float deltaTime)
		{
		}

		public bool IsFinish()
		{
			return false;
		}
	}

	private class TweenTextController : ITweenController
	{
		private UILabel label;

		private AnimationCurve animationCurve;

		private float DURATION;

		private float POSITION_DURATION;

		private float time;

		private float START_POSITION_X;

		private float SHADOW_X;

		private float SHADOW_DURATION;

		public TweenTextController(UILabel label, AnimationCurve animationCurve, float duration, float tweenPositionX, float tweenPositionDuration, float tweenShadowX, float tweenShadowDuration)
		{
		}

		public void Update(float deltaTime)
		{
		}

		private void Position()
		{
		}

		private void Alpha()
		{
		}

		private void Shadow()
		{
		}

		public bool IsFinish()
		{
			return false;
		}
	}

	private interface ITweenController
	{
		void Update(float deltaTime);

		bool IsFinish();
	}

	[Header("Tween Mask")]
	public UISprite mask;

	public float tweenMaskDuration;

	public float tweenMaskMaxAlpha;

	public AnimationCurve maskAnimation;

	[Header("Tween Text")]
	public UILabel lb_text;

	public float tweenTextDuration;

	public float textStartPositionX;

	public float textShadowX;

	public float positionTweenDuration;

	public float shadowTweenDuration;

	public AnimationCurve textAnimation;

	public UILabel lb_touch;

	[Header("Guide")]
	public DungeonLoseGuideView guideView;

	public UIWidget guideContainer;

	public float tweenGuideDuration;

	public float tweenGuideMaxAlpha;

	public AnimationCurve guideAnimation;

	[Header("ClickObject")]
	public GameObject clickObject;

	public GameObject btn_protect;

	public UILabel lb_tip;

	public UIGrid gridButton;

	[Header("Time")]
	public UILabel lb_time;

	private List<ITweenController> tween;

	private bool IsFinish;

	private bool enableClick;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	public void Show(ShowDungeonLosePopupParameters Parameters)
	{
	}

	private void PlayEffect()
	{
	}

	private void Update()
	{
	}

	private void Finish()
	{
	}

	private void ClickObject(GameObject o)
	{
	}

	private void ClickProtect(GameObject o)
	{
	}

	private void DisplayTime()
	{
	}

	private bool IsFirstHellModeLose()
	{
		return false;
	}

	private bool IsJustRemovedOldestLocation()
	{
		return false;
	}
}
