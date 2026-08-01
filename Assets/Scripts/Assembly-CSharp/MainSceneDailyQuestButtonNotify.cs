using SSAR.View;

public class MainSceneDailyQuestButtonNotify : AbsButtonNofity
{
	private DailyQuestNotify notify;

	protected override void Awake()
	{
	}

	protected override bool IsNotify()
	{
		return false;
	}
}
