using SSAR.WorldMap.View;
using UnityEngine;

public class NodeInfoPopup : BasePopup
{
	public UITexture bg;

	public UILabel lb_nodeName;

	public UILabel lb_nodeDescription;

	public NodeRewardContainer nodeRewardContainer;

	public NodeBoostItemContainer nodeBoostItemContainer;

	public GameObject resourceContainer;

	public GameObject btn_close;

	public GameObject btn_enter;

	public UILabel lb_keyRequire;

	private int nodeId;

	private bool backToWorldMapWhenClose;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnHidePopup(BasePopup obj, bool showAnotherPopup)
	{
	}

	protected override void onEnable()
	{
	}

	public void Show(int nodeId, bool backToWorldMapWhenClose)
	{
	}

	public void UpdateBoostItem()
	{
	}

	private void UpdateBg(int nodeId)
	{
	}

	private void Enter(GameObject o)
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
}
