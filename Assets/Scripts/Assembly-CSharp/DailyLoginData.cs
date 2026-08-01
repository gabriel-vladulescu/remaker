using System.Collections.Generic;
using Assets.Scripts.Ssar.DailyLogin.Model;
using LitJson;

public class DailyLoginData
{
	public int receivedGiftCount;

	public int eventId;

	public int timeGenerate;

	public List<int> dayClaimBonusReward;

	[JsonInclude]
	private List<int> dayClaimReward;

	[JsonInclude]
	private List<DailyLoginGift> rewards;

	[JsonInclude]
	private CompactedDailyLoginData compactedData;

	[JsonInclude]
	private int lastTimeClaim;

	[JsonInclude]
	private int lastClaimDay;

	[JsonIgnore]
	public int LastTimeClaim => 0;

	[JsonIgnore]
	public int LastClaimDay => 0;

	public void Init()
	{
	}

	public void ClaimReward(int day)
	{
	}

	public bool IsClaimedBonusReward(int day)
	{
		return false;
	}

	public bool IsClaimedReward(int day)
	{
		return false;
	}

	public List<int> GetListDayClaimedReward()
	{
		return null;
	}

	public void ClaimBonusReward(int day)
	{
	}

	public void UpdateListReward(List<DailyLoginGift> itemInfos)
	{
	}

	public List<DailyLoginGift> GetDailyReward()
	{
		return null;
	}

	public int GetTotalDayClaimed()
	{
		return 0;
	}

	public bool IsCompacted()
	{
		return false;
	}

	public void SetCompactedData(CompactedDailyLoginData compactedDailyLoginData)
	{
	}

	public int GetCompactedReward(ItemType type)
	{
		return 0;
	}

	private void ClearUncompactedData()
	{
	}

	public bool IsValidLastClaimDay()
	{
		return false;
	}
}
