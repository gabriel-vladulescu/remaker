using SSAR.Equipment.Model;

namespace Ssar.Ancient.Command
{
	public class ShowEnhanceAncientSuccessPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public EquipmentCollectData EquipmentCollectData { get; set; }

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
