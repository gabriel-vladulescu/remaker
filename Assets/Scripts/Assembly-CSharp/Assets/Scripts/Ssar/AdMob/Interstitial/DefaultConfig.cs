using System.Collections.Generic;

namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class DefaultConfig : InterstitialAdsFactory.Config
	{
		private long cooldown;

		private List<string> countryBlackList;

		private List<string> countryWhiteList;

		private float rate;

		private int[] levelRange;

		public DefaultConfig(long cooldown, List<string> countryBlackList, float rate, int[] levelRange, List<string> countryWhiteList)
		{
		}

		public long Cooldown()
		{
			return 0L;
		}

		public List<string> CountryBlackList()
		{
			return null;
		}

		public List<string> CountryWhiteList()
		{
			return null;
		}

		public float Rate()
		{
			return 0f;
		}

		public int[] LevelRange()
		{
			return null;
		}
	}
}
