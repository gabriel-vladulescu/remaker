using System;
using Scripts.Config;
using UnityEngine;

namespace Ssar.DailyChallenge.View
{
	public class ChallengeBuffView : MonoBehaviour
	{
		public UISprite sp_icon;

		public UILabel lb_name;

		public UILabel lb_desc;

		public TweenScale TweenScale;

		public TweenScale TweenHide;

		public TweenAlpha tweenAlpha;

		private Action<DailyChallengeConfig.Buff> onSelect;

		private DailyChallengeConfig.Buff buffInfo;

		private GameObject fx;

		private void Awake()
		{
		}

		public void Select()
		{
		}

		public void AddListenerToOnSelect(Action<DailyChallengeConfig.Buff> action)
		{
		}

		public void Show(DailyChallengeConfig.Buff buffInfo, int playAtFrame, int duration)
		{
		}

		public void PlayHide()
		{
		}

		public void Hide()
		{
		}

		public bool ContainBuff(DailyChallengeConfig.Buff buff)
		{
			return false;
		}

		private float GetDuration(int frame)
		{
			return 0f;
		}
	}
}
