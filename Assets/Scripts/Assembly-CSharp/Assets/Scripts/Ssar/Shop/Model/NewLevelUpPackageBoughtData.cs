using System;
using System.Collections.Generic;
using LitJson;

namespace Assets.Scripts.Ssar.Shop.Model
{
	[Serializable]
	public class NewLevelUpPackageBoughtData
	{
		[JsonInclude]
		private int productId;

		[JsonInclude]
		private List<int> levelClaimed;

		public NewLevelUpPackageBoughtData()
		{
		}

		public NewLevelUpPackageBoughtData(int productId)
		{
		}

		public int GetProductId()
		{
			return 0;
		}

		public void ClaimRewardAtLevel(int level)
		{
		}

		public List<int> GetListLevelClaimed()
		{
			return null;
		}

		public bool HasClaimRewardAtLevel(int level)
		{
			return false;
		}
	}
}
