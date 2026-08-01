using Assets.Scripts.Ssar.DataManager;
using Scripts.Config;
using UnityEngine;

public class DailyQuestRowView : AbsQuestRowView
{
	private DailyQuestConfig.QuestItem questItem;

	protected override void ClickClaim(GameObject o)
	{
	}

	protected override bool HasClaimed()
	{
		return false;
	}

	protected override bool CanClaim()
	{
		return false;
	}

	protected override int QuestRequire()
	{
		return 0;
	}

	protected override int CurProgress()
	{
		return 0;
	}

	protected override ItemInfo RewardItemInfo()
	{
		return null;
	}

	protected override string AchivementIcon()
	{
		return null;
	}

	protected override string QuestName()
	{
		return null;
	}

	protected override string QuestDesc()
	{
		return null;
	}

	private DailyQuestData DailyQuestData()
	{
		return null;
	}

	private DailyQuestConfig DailyQuestConfig()
	{
		return null;
	}

	public override void OnShow(WrapContentData data, int index)
	{
	}
}
