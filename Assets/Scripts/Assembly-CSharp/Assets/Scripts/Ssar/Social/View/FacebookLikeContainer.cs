using UnityEngine;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Social.View
{
	public class FacebookLikeContainer : strange.extensions.mediation.impl.View
	{
		public GameObject btn_like;

		public GameObject wg_received;

		public UILabel lb_quantiy;

		public UISprite sp_icon;

		public UITable table;

		private FacebookSocial social;

		private ItemInfo itemInfo;

		protected override void Awake()
		{
		}

		public void Init(FacebookSocial facebookSocial)
		{
		}

		public void UpdateData()
		{
		}

		private void CLick(GameObject o)
		{
		}
	}
}
