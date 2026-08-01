using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ShowShopTreasureBoughtSuccessPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public List<EquipmentConfigId> EquipmentConfigIds { get; set; }

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
