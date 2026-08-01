using Scripts.Config;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Shop.View
{
	public class BasePackView : strange.extensions.mediation.impl.View
	{
		public UILabel lb_reward;

		public UILabel lb_title;

		public UILabel lb_price;

		public UILabel lb_priceBase;

		public UILabel lb_available;

		public UILabel lb_sale;

		public UISprite sp_icon;

		public GameObject btn_buy;

		public GameObject wg_sale;

		public GameObject wg_x2;

		protected void DisplayView(IProductInfo productInfo, string rewardDescription)
		{
		}
	}
}
