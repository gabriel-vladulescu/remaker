using UnityEngine;
using strange.extensions.mediation.impl;

namespace Ssar.RaidBoss.View
{
	public class RaidSeasonTimeLeftView : strange.extensions.mediation.impl.View
	{
		public UILabel lb_text;

		public UILabel lb_progress;

		public UIProgressBar ProgressBar;

		public GameObject btn_reward;

		public GameObject btn_previousReward;

		private TextLoading textLoading;

		private bool wait;

		private float time;

		private float DELAY;

		private GameObject fx;

		private TweenRotation tweenRotation;

		private TweenPosition tweenPosition;

		private RaidDifficulty curDifficulty;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		private void ClickReward(GameObject go)
		{
		}

		private void Update()
		{
		}

		public void Show(RaidDifficulty difficulty)
		{
		}

		public void UpdateData()
		{
		}

		public void UpdateSeasonTimeProgress()
		{
		}

		private bool CanClaim()
		{
			return false;
		}

		private void InitFx()
		{
		}

		private void EnableTween(bool active)
		{
		}
	}
}
