using System.Collections.Generic;
using Assets.Scripts.Ssar.Shop.Model;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class SubscribePackageRowView : MonoBehaviour
	{
		public UILabel lb_tip;

		private List<ItemInfo> reward;

		public LevelUpPackageRewardView[] RewardViews;

		public GameObject btn_claim;

		public GameObject wg_claimed;

		private int index;

		private ISubscribePackageLogic subscribePackageLogic;

		private void Awake()
		{
		}

		public void Show(ISubscribePackageLogic subscribePackageLogic, int index)
		{
		}

		public void Hide()
		{
		}

		public void UpdateData()
		{
		}

		private void Claim(GameObject o)
		{
		}

		private string GetTitle()
		{
			return null;
		}

		private bool IsInstant()
		{
			return false;
		}

		private int Day()
		{
			return 0;
		}
	}
}
