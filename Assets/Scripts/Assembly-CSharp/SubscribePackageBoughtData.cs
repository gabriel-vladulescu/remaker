using System;
using System.Collections.Generic;

[Serializable]
public class SubscribePackageBoughtData
{
	public int boughtTime;

	public List<int> dayReceived;

	public bool hasClaimRewardInstant;

	public int dayCount;

	public bool HasBought()
	{
		return false;
	}

	public void Bought(int timeInSecond, int dayCount)
	{
	}

	public void ClaimRewardInstant()
	{
	}

	public bool HasClaimRewardInstant()
	{
		return false;
	}

	public void ClaimRewardOfDay(int day)
	{
	}

	public bool HasClaimRewardOfDay(int day)
	{
		return false;
	}

	public bool IsExpired(int currentTime)
	{
		return false;
	}

	public int DayRemaining(int currentTime)
	{
		return 0;
	}
}
