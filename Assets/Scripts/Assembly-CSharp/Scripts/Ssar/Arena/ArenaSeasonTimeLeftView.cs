using UnityEngine;
using strange.extensions.mediation.impl;

namespace Scripts.Ssar.Arena
{
	public class ArenaSeasonTimeLeftView : View
	{
		public UILabel lb_text;

		public UILabel lb_progress;

		public UIProgressBar ProgressBar;

		public GameObject btn_reward;

		public GameObject btn_previousReward;

		private Material grayScaleMaterial;

		private TextLoading textLoading;

		private bool wait;

		private float time;

		private float DELAY;

		private GameObject fx;

		private TweenRotation tweenRotation;

		private TweenPosition tweenPosition;

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		private void ClickBtnPreviousReward(GameObject go)
		{
		}

		private void ClickBtnReward(GameObject go)
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

		private void Update()
		{
		}

		private void InitFx()
		{
		}

		private void EnableTween(bool active)
		{
		}
	}
}
