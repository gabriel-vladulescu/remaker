using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.AdMob.Interstitial
{
	public class InterstitialAds
	{
		public interface Requirement
		{
			void Touch();

			bool IsMet();

			string Reason();

			void OnAdsShown();
		}

		private static InterstitialAds instance;

		private IronSrcSource ironSrc;

		private List<Requirement> requirements;

		private bool prepared;

		public static InterstitialAds Instance => null;

		public void Init(string ironsrcAppKey)
		{
		}

		public void Prepare()
		{
		}

		public bool IsAvailable()
		{
			return false;
		}

		public void Show(Action<bool> callback)
		{
		}

		public void RequestNewAds()
		{
		}

		public void AddRequirement(Requirement r)
		{
		}
	}
}
