using Assets.Scripts.Ssar.DataManager;
using Scripts.Config;

public class DailyQuestNotify
{
	private DailyQuestData dailyQuestData;

	private DailyQuestConfig dailyQuestConfig;

	public bool IsNotify()
	{
		return false;
	}

	private bool CanClaimedMasterQuest()
	{
		return false;
	}

	private bool CanClaimDailyQuest()
	{
		return false;
	}
}
