using System.Collections.Generic;
using UnityEngine;

namespace SSAR.Shop.View
{
	public class BundlePackageOneProductResourcesContainer : MonoBehaviour
	{
		public OneProductResourcesView soul;

		public OneProductResourcesView gem;

		public OneProductResourcesView legendaryEssence;

		public OneProductResourcesView ultimateEssence;

		private bool hideGem;

		private bool hideSoul;

		public bool HideGem => false;

		public bool HideSoul => false;

		public void Show(List<ItemInfo> itemInfos)
		{
		}
	}
}
