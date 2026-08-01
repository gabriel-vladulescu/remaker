using System.Collections.Generic;

public class LoadMultiAssetsRequest
{
	public List<LoadAssetRequest> request;

	public MultiAssetsCompleteDelegate MultiAssetsCompleteDelegate;

	public MultiAssetsFailureDelegate AssetFailureDelegate;

	public LoadMultiAssetsRequest(List<LoadAssetRequest> list)
	{
	}

	public LoadMultiAssetsRequest AddAssetCompleteDelegate(MultiAssetsCompleteDelegate del)
	{
		return null;
	}

	public LoadMultiAssetsRequest AddAssetFailureDelegate(MultiAssetsFailureDelegate del)
	{
		return null;
	}
}
