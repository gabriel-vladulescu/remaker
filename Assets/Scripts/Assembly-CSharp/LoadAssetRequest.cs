public class LoadAssetRequest
{
	public string resourcePath;

	public AssetSuccessDelegate assetSuccessDelegate;

	public AssetFailureDelegate assetFailureDelegate;

	public AssetProgressDelegate assetProgressDelegate;

	public LoadAssetRequest(string resourcePath, AssetSuccessDelegate assetSuccessDelegate, AssetFailureDelegate assetFailureDelegate = null)
	{
	}

	public LoadAssetRequest AddAssetSuccessDelegate(AssetSuccessDelegate del)
	{
		return null;
	}

	public LoadAssetRequest AddAssetFailureDelegate(AssetFailureDelegate del)
	{
		return null;
	}

	public LoadAssetRequest AddAssetProgressDelegate(AssetProgressDelegate del)
	{
		return null;
	}
}
