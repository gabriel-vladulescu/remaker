using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Social.Model
{
	[Serializable]
	public class FacebookRewardData
	{
		public bool hasLike;

		public List<string> facebookIdInvited;

		public bool hasJoinGroup;

		public int lastTimeShare;

		public int todayShareCount;

		public bool hasLoginFacebook;

		public bool HasLike()
		{
			return false;
		}

		public void SetLiked()
		{
		}

		public bool HasJoin()
		{
			return false;
		}

		public bool HasLoginFacebook()
		{
			return false;
		}

		public void SetJoinGroup()
		{
		}

		public void SetLoginFacebook()
		{
		}

		public int GetNumOfUserInvited()
		{
			return 0;
		}

		public void AddUserInvited(List<string> faebookId)
		{
		}

		public void ShareSuccess(int timeInSecond)
		{
		}

		public int GetToDayShareCount()
		{
			return 0;
		}

		public int GetLastTimeShare()
		{
			return 0;
		}

		public void ResetTodayShareCount()
		{
		}
	}
}
