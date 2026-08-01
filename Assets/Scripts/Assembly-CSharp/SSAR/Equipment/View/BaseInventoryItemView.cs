using System.Collections.Generic;
using SSAR.Equipment.Enum;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class BaseInventoryItemView : strange.extensions.mediation.impl.View
	{
		protected ICollectData collectData;

		protected CollectType collectType;

		private List<IOverlay> overLayConfig;

		protected new virtual void Awake()
		{
		}

		public void Show(ICollectData collectData)
		{
		}

		protected void CheckOverLay()
		{
		}

		private void ClearOldOverlay()
		{
		}

		private int ComparerOverlay(IOverlay a, IOverlay b)
		{
			return 0;
		}

		public void Hide()
		{
		}

		public int GetCollectID()
		{
			return 0;
		}

		public CollectType GetCollectType()
		{
			return default(CollectType);
		}

		protected virtual void OnShow(ICollectData collectData)
		{
		}

		public virtual bool IsCanClick()
		{
			return false;
		}

		public virtual int GetSlot()
		{
			return 0;
		}

		protected virtual List<IOverlay> Overlay()
		{
			return null;
		}
	}
}
