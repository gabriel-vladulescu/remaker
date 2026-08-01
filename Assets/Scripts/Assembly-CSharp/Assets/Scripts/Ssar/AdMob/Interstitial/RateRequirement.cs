namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class RateRequirement : InterstitialAds.Requirement
	{
		private float rate;

		private bool hit;

		public RateRequirement(float rate)
		{
		}

		public void Touch()
		{
		}

		public bool IsMet()
		{
			return false;
		}

		public string Reason()
		{
			return null;
		}

		public void OnAdsShown()
		{
		}
	}
}
