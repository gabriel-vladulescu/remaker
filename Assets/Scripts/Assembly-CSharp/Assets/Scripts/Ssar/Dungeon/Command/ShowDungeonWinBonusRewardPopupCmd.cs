using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class ShowDungeonWinBonusRewardPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public List<ItemInfo> reward { get; set; }

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
}
