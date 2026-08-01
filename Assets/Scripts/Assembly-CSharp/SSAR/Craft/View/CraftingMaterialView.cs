using Ssar.Craft.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftingMaterialView : MonoBehaviour
	{
		public UILabel lb_name;

		public UILabel lb_quantity;

		public UISprite sp_rarity;

		public UISprite sp_icon;

		private UISprite sp_random;

		private CraftingMaterial material;

		private void Awake()
		{
		}

		private void ClickItem(GameObject go)
		{
		}

		private void InitSpriteRandom()
		{
		}

		private string GetColor(int curQuantity, int requiredQuantity)
		{
			return null;
		}

		internal void Show(ICollectData collectData)
		{
		}

		internal void ShowRandomQuanity(ICollectData collectData)
		{
		}

		internal void Show(ICollectData collectData, int requiredQuantity)
		{
		}

		internal void Hide()
		{
		}
	}
}
