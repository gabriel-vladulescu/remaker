using System.Collections.Generic;
using SSAR.WorldMap.view;
using strange.extensions.mediation.impl;

namespace SSAR.WorldMap.View
{
	public class NodeBoostItemContainer : strange.extensions.mediation.impl.View
	{
		public UITable table;

		public UILabel lb_text;

		private List<BoostItemView> boostItemViews;

		private Dictionary<BoostItemType, bool> dict;

		private string text;

		private BoostItemType[] boostItemTypes;

		protected override void Awake()
		{
		}

		public void Show(int nodeId)
		{
		}

		private void UpdateData()
		{
		}

		private void Init()
		{
		}

		public void OnSelectItem(BoostItemType boostItemType)
		{
		}

		public void OnUnSelectItem(BoostItemType boostItemType)
		{
		}

		private void UpdateText()
		{
		}
	}
}
