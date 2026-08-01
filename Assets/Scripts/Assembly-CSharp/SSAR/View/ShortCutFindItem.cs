using UnityEngine;

namespace SSAR.View
{
	public class ShortCutFindItem : MonoBehaviour
	{
		public enum FindItemType
		{
			WEAPON = 0,
			ARMOR = 1,
			ACCESSORY = 2,
			COSMETIC = 3,
			PET = 4,
			RUNE = 5,
			ORE_RUNE = 6,
			CRAFTING_MATERIAL = 7,
			ANCIENT = 8
		}

		public UIWidget container;

		public UILabel lb_shortCut;

		public GameObject btn_shortCut;

		private FindItemType findItemType;

		private void Awake()
		{
		}

		private void ShortCut(GameObject go)
		{
		}

		public void Anchor(UIWidget widget)
		{
		}

		public void Show(FindItemType findItemType)
		{
		}

		public void Hide()
		{
		}
	}
}
