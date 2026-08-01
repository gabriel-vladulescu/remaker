namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class CooldownRequirement : InterstitialAds.Requirement
	{
		private long cooldownInSeconds;

		private long lastTimeShow;

		public CooldownRequirement(long cooldownInSeconds)
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
