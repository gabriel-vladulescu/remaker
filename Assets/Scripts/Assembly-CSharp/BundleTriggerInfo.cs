public class BundleTriggerInfo
{
	public string type { get; set; }

	public string cookies { get; set; }

	public BundleTriggerType GetBundleTriggerType()
	{
		return default(BundleTriggerType);
	}
}
