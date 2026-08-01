using Assets.Scripts.Model;
using SSAR.Equipment.View;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class ShowAwakenEquipmentSuccessPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public EquipmentView EquipmentView { get; set; }

		[Inject]
		public IItem EquipmentCollectData { get; set; }

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
