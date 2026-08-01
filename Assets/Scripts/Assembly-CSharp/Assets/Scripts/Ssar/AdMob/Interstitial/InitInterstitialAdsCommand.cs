using System.Collections.Generic;
using Assets.Scripts.Ssar.Common.System;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class InitInterstitialAdsCommand : strange.extensions.command.impl.Command
	{
		private class InterstitialAdsFactoryConfigFromTxt : InterstitialAdsFactory.Config
		{
			private InterstitialAdsConfig config;

			public InterstitialAdsFactoryConfigFromTxt(InterstitialAdsConfig config)
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

		[Inject(/*Could not decode attribute arguments.*/)]
		public DefaultSystem defaultSystem { get; set; }

		public override void Execute()
		{
		}
	}
}
