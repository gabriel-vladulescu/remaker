using System.Collections.Generic;
using LitJson;

public class FeatureUnlockedData
{
	[JsonInclude]
	private List<FeatureName> featuresUnlocked;

	public bool HasUnlocked(FeatureName featureName)
	{
		return false;
	}

	public void UnlockFeature(FeatureName featureName)
	{
	}
}
