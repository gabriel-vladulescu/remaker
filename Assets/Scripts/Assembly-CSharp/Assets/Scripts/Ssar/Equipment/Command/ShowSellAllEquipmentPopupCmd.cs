namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class ShowSellAllEquipmentPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public EquipmentCombinedType EquipmentCombinedType { get; set; }

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
