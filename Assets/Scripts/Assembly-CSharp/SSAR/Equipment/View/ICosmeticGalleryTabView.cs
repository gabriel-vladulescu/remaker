using System;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public abstract class ICosmeticGalleryTabView<T> : strange.extensions.mediation.impl.View where T : struct, IComparable, IFormattable, IConvertible
	{
		public UIToggle toggle;

		public GameObject wg_active;

		public GameObject lb_tab;

		private T tabType;

		public Action<T> onSelect;

		protected override void Awake()
		{
		}

		public void Init(T tabType, Action<T> onSelect)
		{
		}

		public void OnChangeTab(T tabType)
		{
		}

		public void onChange()
		{
		}

		private void Select(GameObject o)
		{
		}
	}
}
