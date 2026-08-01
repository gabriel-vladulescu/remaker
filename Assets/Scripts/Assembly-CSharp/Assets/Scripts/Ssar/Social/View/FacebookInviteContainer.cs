using Scripts.Config;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Social.View
{
	public class FacebookInviteContainer : strange.extensions.mediation.impl.View
	{
		public GameObject btn_invite;

		public GameObject wg_received;

		public UILabel lb_quantiy;

		public UISprite sp_icon;

		public UISprite sp_maxicon;

		public UITable table;

		public UILabel lb_desc;

		public UITable table_desc;

		private FacebookSocial social;

		private FacebookInviteRewardInfo facebookInviteRewardInfo;

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
