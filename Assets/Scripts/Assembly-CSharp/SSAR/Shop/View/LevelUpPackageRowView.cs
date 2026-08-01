using System.Collections.Generic;
using Assets.Scripts.Ssar.Shop.Model;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class LevelUpPackageRowView : MonoBehaviour
	{
		public UILabel lb_tip;

		public LevelUpPackageRewardView[] RewardViews;

		public GameObject btn_claim;

		public GameObject wg_claimed;

		public int level;

		private IShowLevelUpPackagePopupParameter parameter;

		private void Awake()
		{
		}

		public void Show(int level, List<ItemInfo> reward, IShowLevelUpPackagePopupParameter parameter)
		{
		}

		public void UpdateData()
		{
		}

		private void Claim(GameObject o)
		{
		}
	}
}
