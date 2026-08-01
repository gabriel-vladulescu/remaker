using System;
using UnityEngine;

namespace SSAR.View
{
	public abstract class AbsTabView<T> : MonoBehaviour where T : struct, IComparable, IFormattable, IConvertible
	{
		public UIToggle toggle;

		public GameObject wg_active;

		public GameObject lb_tab;

		protected T tabType;

		public Action<T> onSelect;

		protected void Awake()
		{
		}

		public void Init(T tabType, Action<T> onSelect)
		{
		}

		public void OnChangeTab(T tabType)
		{
		}

		private void onChange()
		{
		}

		protected virtual void Select(GameObject o)
		{
		}

		protected abstract string GetTabName(T tabtype);
	}
}
