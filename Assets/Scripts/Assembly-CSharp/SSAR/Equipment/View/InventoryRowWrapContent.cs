using System.Collections.Generic;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class InventoryRowWrapContent : UIWrapContent
	{
		public bool autoOverrideAnchorUpdate;

		public bool autoAnchorTopLeftCorner;

		public Vector3 offsetAnchor;

		private List<ICollectData> data;

		private AbstractInventoryView inventoryView;

		private int count;

		private bool isInit;

		public virtual void Setup(AbstractInventoryView inventoryView, List<ICollectData> data, int count)
		{
		}

		private void SetActiveAllChildren()
		{
		}

		private void InitData()
		{
		}

		private void Init()
		{
		}

		private void InstantiateRow(int i)
		{
		}

		protected override void UpdateItem(Transform item, int index, UpdateItemPivot pivot)
		{
		}

		protected override bool CheckUpdateItem(int index, UpdateItemPivot pivot)
		{
			return false;
		}

		public void UpdateCurrentVisibleRow(List<ICollectData> currentCollectDatas)
		{
		}

		private bool HasCollectData(int collectID, List<ICollectData> collectDatas)
		{
			return false;
		}

		private bool EndRowHasData(int endRowIndex, List<ICollectData> currentCollectDatas)
		{
			return false;
		}

		public int NumOfRowVisible()
		{
			return 0;
		}
	}
}
