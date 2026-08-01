using Assets.Scripts.Ssar.Dungeon.Command;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class ArenaOpponentInfoPopup : BasePopup
	{
		public UILabel lb_name;

		public UILabel lb_textLv;

		public UILabel lb_attackPower;

		public UILabel lb_leaguage;

		public UISprite sp_tier;

		public UISprite sp_division;

		public UILabel lb_division;

		public UILabel lb_lv;

		public TweenAlpha TweenAlpha;

		public void Show(ShowArenaOpponentInfoPopupParameter parameter)
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}
	}
}
