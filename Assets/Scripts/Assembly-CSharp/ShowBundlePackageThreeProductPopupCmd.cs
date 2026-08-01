using Ssar.Analytics.Metrics;

public class ShowBundlePackageThreeProductPopupCmd : BaseShowPopupCmd
{
	[Inject]
	public AbsShowPackageThreeProductParameter Parameter { get; set; }

	[Inject]
	public Metric metric { get; set; }

	public override void Execute()
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
