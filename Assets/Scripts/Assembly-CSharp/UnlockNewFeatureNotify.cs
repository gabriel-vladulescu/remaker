using System;
using Scripts.Config;

public class UnlockNewFeatureNotify : AbsPopupNotify
{
	private readonly FeatureName _featureName;

	private ConfigManager configManager;

	private MainCharacterData mainCharacterData;

	private FeatureUnlockInfo info;

	public UnlockNewFeatureNotify(FeatureUnlockInfo info)
	{
	}

	public override void Process(Action onContinue, Action onBreak)
	{
	}

	public override bool IsNotify(string sceneName)
	{
		return false;
	}

	public override string[] SceneActive()
	{
		return null;
	}

	protected override void OnShow()
	{
	}

	public override bool IsByPassCheckTutorial()
	{
		return false;
	}
}
