using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.StarChest.View
{
	public class StarChestRewardPopup : BasePopup
	{
		public UILabel lb_title;

		public UITable table;

		public GameObject btn_close;

		private List<StarChestRewardPopupRow> rows;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show(MapInfo mapInfo, ScenarioDifficulty difficulty)
		{
		}

		private int Comaprer(ScenarioStarChestRewardInfo a, ScenarioStarChestRewardInfo b)
		{
			return 0;
		}

		private void InitTabke()
		{
		}
	}
}
