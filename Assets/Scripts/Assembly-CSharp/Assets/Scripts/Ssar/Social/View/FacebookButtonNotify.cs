using Assets.Scripts.Ssar.Social.Model;
using SSAR.View;

namespace Assets.Scripts.Ssar.Social.View
{
	public class FacebookButtonNotify : AbsButtonNofity
	{
		protected override bool IsNotify()
		{
			return false;
		}

		private bool HasLogin()
		{
			return false;
		}

		private bool HasLike()
		{
			return false;
		}

		private bool HasJoinGroup()
		{
			return false;
		}

		private bool IsReachMaxInvite()
		{
			return false;
		}

		private bool IsReachMaxShare()
		{
			return false;
		}

		private FacebookRewardData FaceBookRewardData()
		{
			return null;
		}
	}
}
