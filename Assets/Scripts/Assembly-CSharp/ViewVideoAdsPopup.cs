using UnityEngine;

public class ViewVideoAdsPopup : BasePopup
{
	public UILabel lb_currentVod;

	public UILabel lb_vodRequire;

	public UILabel lb_desc;

	public GameObject btn_cancel;

	public GameObject btn_watch;

	private ShowViewVideoAdsPopupParameter parameter;

	protected override void Awake()
	{
	}

	public void Show(ShowViewVideoAdsPopupParameter parameter)
	{
	}

	private new void Hide(GameObject o)
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	private void Watch(GameObject o)
	{
	}
}
