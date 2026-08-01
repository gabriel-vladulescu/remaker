using System.Collections.Generic;
using Ssar.Craft.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftableItemHeaderView : MonoBehaviour
	{
		public UILabel lbName;

		public UITable containerTable;

		public UIGrid containerGrid;

		private GameObject prefab;

		private List<CraftableItemView> ItemViews;

		private void Awake()
		{
		}

		private void Init()
		{
		}

		private void CreateItemViews(int count)
		{
		}

		private void ShowItems(List<CraftableItem> items)
		{
		}

		private void ShowHeader(string type, string suffix)
		{
		}

		internal void Show(string type, string suffix, List<CraftableItem> items)
		{
		}

		internal void Hide()
		{
		}
	}
}
