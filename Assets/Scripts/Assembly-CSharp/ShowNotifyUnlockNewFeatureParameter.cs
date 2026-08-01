using System;

public class ShowNotifyUnlockNewFeatureParameter
{
	public Action OnHide { get; set; }

	public string IconName { get; set; }

	public string FeatureName { get; set; }

	public ShowNotifyUnlockNewFeatureParameter(Action onHide, string iconName, string featureName)
	{
	}
}
