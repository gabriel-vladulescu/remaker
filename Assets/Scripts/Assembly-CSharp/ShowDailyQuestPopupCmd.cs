using System;
using Scripts.Config;
using Ssar.Analytics.Metrics;

public class ShowDailyQuestPopupCmd : BaseShowPopupCmd
{
	[Inject]
	public Action onFinish { get; set; }

	[Inject]
	public Metric metric { get; set; }

	[Inject]
	public ConfigManager configManager { get; set; }

	public override void Execute()
	{
	}

	private void SendFeatureMetricDailyMissionShow()
	{
	}

	protected override string GetAssetPath()
	{
		return null;
	}

	protected override string GetInjectName()
	{
		return null;
	}

	protected override PopupCamera GetCamera()
	{
		return default(PopupCamera);
	}
}
