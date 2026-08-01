using Assets.Scripts.Ssar.Signal;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class ShowBundlePackageOneProductPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public AbsShowPackageInfoParameter Parameter { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		[Inject]
		public ShowAncientEquipmentPackagePopupSignal ShowAncientEquipmentPackagePopupSignal { get; set; }

		public override void Execute()
		{
		}

		private void HideAncient()
		{
		}

		private void HidePopupNormal()
		{
		}

		private void HidePopupPlus()
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

		private bool IsAncientEquipmentPackage(AbsShowPackageInfoParameter parameter)
		{
			return false;
		}

		private bool IsPlusEquipmentPackage(AbsShowPackageInfoParameter parameter)
		{
			return false;
		}
	}
}
