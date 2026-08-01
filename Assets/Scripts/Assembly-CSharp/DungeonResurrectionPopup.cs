using UnityEngine;

public class DungeonResurrectionPopup : BasePopup
{
	public UILabel lb_cost;

	public GameObject btn_exit;

	public GameObject btn_resurrection;

	public TweenHeight TweenHeight;

	public TweenAlpha TweenAlpha;

	public UILabel lb_point;

	private int currentVod;

	private MainCharacterData mainCharacterData;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	protected override void ExecuteBack()
	{
	}

	public void Show()
	{
	}

	private void Effect()
	{
	}

	private void Exit(GameObject o)
	{
	}

	private void ClickResurrection(GameObject o)
	{
	}

	private int VodRequire()
	{
		return 0;
	}

	private bool IsEnoughVod()
	{
		return false;
	}
}
