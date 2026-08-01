using Ssar.Craft.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftingMaterialInfoPopup : BasePopup
	{
		public GameObject container;

		private CraftingMaterialInfoView infoView;

		protected override void Awake()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		private void InitInfoView()
		{
		}

		internal void Show(CraftingMaterial material)
		{
		}
	}
}
