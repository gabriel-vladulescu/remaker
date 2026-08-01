using UnityEngine;
using strange.extensions.mediation.impl;

namespace Scripts.Ssar.Arena
{
	public class ArenaTodayParticipationView : View
	{
		public UILabel lb_text;

		public UILabel lb_progress;

		public UIProgressBar ProgressBar;

		public GameObject btn_claim;

		private Material grayScaleMaterial;

		private new void Awake()
		{
		}

		private new void OnEnable()
		{
		}

		public void UpdateData()
		{
		}

		private void Claim(GameObject go)
		{
		}

		private bool CanClaim()
		{
			return false;
		}

		private bool HasClaim()
		{
			return false;
		}

		private int CurrentParticipateReward()
		{
			return 0;
		}

		private int CurrentParticipate()
		{
			return 0;
		}
	}
}
