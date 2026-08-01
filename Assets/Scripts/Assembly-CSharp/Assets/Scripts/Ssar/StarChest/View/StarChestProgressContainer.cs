using Scripts.Config;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.StarChest.View
{
	public class StarChestProgressContainer : strange.extensions.mediation.impl.View
	{
		public UILabel lb_star;

		public UIProgressBar Progress;

		public StarChestProgressChestView[] chest;

		private MapInfo mapInfo;

		private ScenarioDifficulty difficulty;

		public void Show(MapInfo mapInfo, ScenarioDifficulty difficulty)
		{
		}

		public void UpdateData()
		{
		}

		private void UpdateChest()
		{
		}
	}
}
