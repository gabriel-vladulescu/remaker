using System.Collections.Generic;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class BaseInventoryRowView : MonoBehaviour
	{
		private UITable table;

		private BaseInventoryItemView[] itemViews;

		public int rowIndex;

		public List<ICollectData> datas;

		private void Awake()
		{
		}

		private void Active()
		{
		}

		private void Hide()
		{
		}

		public void Show(List<ICollectData> collectData, int rowIndex)
		{
		}

		private void InstantiateChild()
		{
		}

		protected virtual string GetItemAssetPath()
		{
			return null;
		}

		protected virtual void OnInstantiateItem(GameObject item)
		{
		}

		protected virtual void OnFinishInstantiateItem()
		{
		}
	}
}
