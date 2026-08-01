using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.DataManager;

[Serializable]
public class QuinnRequestEventData
{
	public int eventId;

	public int eventCoin;

	public int totalEventCoin;

	public int viewCount;

	public int dailyCount;

	public int totalQuest;

	public int totalDailyQuest;

	public int lastTimeLoginInSeconds;

	public int previousEarnCoins;

	public int previousSpendCoins;

	public int previousExchangeTimes;

	public List<Progress> questProgresses;

	public Dictionary<string, DailyQuestStatus> questStatuses;

	public List<int> packsData;

	private const string UNDERSCORE = "_";

	public string GetTotalGiftId()
	{
		return null;
	}

	public int GetTotalExchangeTime()
	{
		return 0;
	}

	public void AddProgress(Progress p)
	{
	}

	public bool FindProgress(int id, ref Progress progress)
	{
		return false;
	}

	public bool IsClaimed(int questId)
	{
		return false;
	}

	public void ClaimDailyQuest(int questId)
	{
	}

	public void ClaimEventCoin(int amount)
	{
	}

	public void SpendEventCoin(int amount)
	{
	}

	public int GetPurchasedCount(int productId)
	{
		return 0;
	}

	public void PurchasePack(int productId)
	{
	}
}
