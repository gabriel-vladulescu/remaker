using Assets.Scripts.Model;

namespace Assets.Scripts.Ssar.Command
{
	public class ShowAwakenEquipmentPopupCmd : BaseShowPopupCmd
	{
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
