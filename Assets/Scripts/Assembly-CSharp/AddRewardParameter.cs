using System;
using System.Collections.Generic;

public class AddRewardParameter
{
	public List<ItemInfo> ItemInfos;

	public Action finish;

	public bool showPopup;

	public string source;

	public RewardReason rewardReason;

	public AddRewardParameter(List<ItemInfo> ItemInfos, Action finish, bool showPopup, string source, RewardReason rewardReason)
	{
	}

	private void AddItem(List<ItemInfo> item, ItemInfo reward, int quantity)
	{
	}
}
