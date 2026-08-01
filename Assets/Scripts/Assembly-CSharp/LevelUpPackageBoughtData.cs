using System;
using System.Collections.Generic;

[Serializable]
public class LevelUpPackageBoughtData
{
	public bool hasBought;

	public List<int> levelClaimed;

	public void Bought()
	{
	}

	public bool HasBought()
	{
		return false;
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
