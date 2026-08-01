using System;
using System.Collections.Generic;
using LitJson;
using Scripts.Config;

namespace Ssar.Craft.Model
{
	[Serializable]
	public class CraftingData
	{
		[JsonInclude]
		private List<CraftItemProgress> items;

		[JsonInclude]
		private List<CraftConfig.Feature> initRewardsClaimed;

		public void CraftItem(int recipeId, int visualId, int startTime)
		{
		}

		public void ReceiveItem(int recipeId, int visualId)
		{
		}

		public bool IsCrafting(int recipeId, int visualId)
		{
			return false;
		}

		public CraftItemProgress GetCraftItemProgress(int recipeId, int visualId)
		{
			return null;
		}

		public CraftItemProgress[] GetAllCraftItemProgresses()
		{
			return null;
		}

		public bool IsClaimedInitRewards(CraftConfig.Feature feature)
		{
			return false;
		}

		public void ClaimInitRewards(CraftConfig.Feature feature)
		{
		}
	}
}
