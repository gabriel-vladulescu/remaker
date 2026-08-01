using Ssar.Craft.Model;

namespace Ssar.Craft.Command
{
	public class ShowCraftingMaterialManagerPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public CraftingMaterial material { get; set; }

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
