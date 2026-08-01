using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.MemoryShard
{
	public class MemoryShardPopupTabView : MonoBehaviour
	{
		public GameObject wg_active;

		public UILabel lb_tab;

		public MemoryShardPopupTabType tabType;

		private bool sendSignal;

		private bool isBlockedForUpgrade;

		public Action<MemoryShardPopupTabType> onSelect;

		private void Awake()
		{
		}

		public void onChange(bool IsSelect)
		{
		}

		public void Select(GameObject o)
		{
		}

		public void UnSelect()
		{
		}
	}
}
