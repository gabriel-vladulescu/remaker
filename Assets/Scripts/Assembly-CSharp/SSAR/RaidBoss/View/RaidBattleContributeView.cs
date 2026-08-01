using Ssar.RaidBoss.Model;
using strange.extensions.mediation.impl;

namespace Ssar.RaidBoss.View
{
	public class RaidBattleContributeView : strange.extensions.mediation.impl.View
	{
		private class ContributerInfo
		{
			public string name;

			public float damage;

			public ContributerInfo(string name, float damage)
			{
			}
		}

		public UITable container;

		private RaidBattleData raidBattleData;

		private RaidBattleContributeStatView[] statViews;

		private bool isInited;

		private float delayCountdown;

		private const int MAX_CONTRIBUTER = 3;

		private const float UPDATE_INTERVAL = 0.5f;

		protected override void Awake()
		{
		}

		private void InitStatViews()
		{
		}

		private void Update()
		{
		}

		private void UpdateDataManager()
		{
		}

		private void UpdateContributer()
		{
		}

		private ContributerInfo[] GetContributerInfos()
		{
			return null;
		}
	}
}
