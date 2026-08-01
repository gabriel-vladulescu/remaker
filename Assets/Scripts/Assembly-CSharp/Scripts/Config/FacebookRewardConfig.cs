using System.Collections.Generic;

namespace Scripts.Config
{
	public class FacebookRewardConfig : IConfig
	{
		public Dictionary<string, FacebookLikeRewardInfo> like;

		public Dictionary<string, FacebookInviteRewardInfo> invite;

		public Dictionary<string, FacebookShareRewardInfo> share;

		public Dictionary<string, FacebookJoinUsRewardInfo> joinUs;

		public Dictionary<string, FacebookLoginRewardInfo> login;

		private FacebookLikeRewardInfo facebookLikeRewardInfo;

		private FacebookInviteRewardInfo facebookInviteRewardInfo;

		private FacebookJoinUsRewardInfo facebookJoinUsRewardInfo;

		private FacebookLoginRewardInfo facebookLoginRewardInfo;

		private List<FacebookShareRewardInfo> facebookShareRewardInfos;

		public void OnMapValue(string content)
		{
		}

		public FacebookLikeRewardInfo GetFacebookLikeRewardInfo()
		{
			return null;
		}

		public FacebookInviteRewardInfo GetFacebookInviteRewardInfo()
		{
			return null;
		}

		public FacebookJoinUsRewardInfo GetFacebookJoinUsRewardInfo()
		{
			return null;
		}

		public List<FacebookShareRewardInfo> GetListFacebookShareRewardInfos()
		{
			return null;
		}

		public FacebookLoginRewardInfo GetFacebookLoginRewardInfo()
		{
			return null;
		}

		public FacebookShareRewardInfo GetShareRewardInfo(int shareCount)
		{
			return null;
		}

		private int Comparer(FacebookShareRewardInfo a, FacebookShareRewardInfo b)
		{
			return 0;
		}
	}
}
