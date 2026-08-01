using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class DoublePackageCategoryPopupItemView : BasePackView
	{
		private DoubleExpPackageProductInfo productInfo;

		private UISprite sp_banner;

		private UILabel lb_day;

		private UILabel lb_month;

		private UITable table;

		private bool inited;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void Show(DoubleExpPackageProductInfo productInfo)
		{
		}

		public void Hide()
		{
		}

		private string RewardDescription(DoubleExpPackageProductInfo productInfo)
		{
			return null;
		}

		public void Buy(GameObject o)
		{
		}

		private void Init()
		{
		}
	}
}
