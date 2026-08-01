using System.Collections.Generic;
using Ssar.Craft.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftableItemInventoryView : MonoBehaviour
	{
		public SimpleWrapContent SimpleWrapContent;

		public int columns;

		private WraptContentInstantiateChild wraptContentInstantiateChild;

		public void Show(List<CraftableItem> items)
		{
		}
	}
}
