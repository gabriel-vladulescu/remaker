using System.Collections.Generic;

namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class InterstitialAdsFactory
	{
		public interface Config
		{
			long Cooldown();

			List<string> CountryBlackList();

			List<string> CountryWhiteList();

			float Rate();

			int[] LevelRange();
		}

		private string ironSourceAppKey;

		private Config config;

		private UserData userData;

		public InterstitialAdsFactory(string ironSourceAppKey, Config config, UserData userData)
		{
		}

		public InterstitialAds Produce()
		{
			return null;
		}
	}
}
