using System;
using Assets.Scripts.Ssar.Dungeon.Command;

public class DungeonPickupPopup : BasePopup
{
	public UISprite sp_icon;

	public UISprite sp_rarity;

	public UISprite sp_bg;

	public UILabel lb_enhance;

	public UILabel lb_rarity;

	public UILabel lb_tier;

	public UILabel lb_text;

	public UIPlayTween PlayTween;

	public UIWidget wg;

	public UIWidget wg_tier;

	private Action onFinish;

	private int originalHeight;

	protected override void Awake()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show(DungeonPickupParameters parameters)
	{
	}

	private void ShowEquipment(EquipmentConfigId equipmentConfig)
	{
	}
}
