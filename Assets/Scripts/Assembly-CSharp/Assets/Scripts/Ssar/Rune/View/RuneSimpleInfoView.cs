using SSAR.Equipment.View;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class RuneSimpleInfoView : BaseInventoryItemView
	{
		public UILabel lb_name;

		public UILabel lb_quantity;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		protected override void OnShow(ICollectData collectData)
		{
		}
	}
}
