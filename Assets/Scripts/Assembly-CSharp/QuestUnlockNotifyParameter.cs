using Scripts.Config;

public class QuestUnlockNotifyParameter
{
	public string icon;

	public string text;

	public UIAtlas atlas;

	public QuestUnlockNotifyParameter(JsonAchievementConfig.AchievementItem achievementItem)
	{
	}

	public QuestUnlockNotifyParameter(DailyQuestConfig.QuestItem dailyQuestItem)
	{
	}

	public QuestUnlockNotifyParameter(PiggyBankItem item, int soulSaved)
	{
	}

	public QuestUnlockNotifyParameter(CampaignConfig.CampaignQuestItem campaignQuestItem)
	{
	}

	public void ModifyIcon(UISprite spIcon)
	{
	}
}
