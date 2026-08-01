using System;
using SSAR.Entry.Model;
using Ssar.Rune.Model;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class ChestTabView : strange.extensions.mediation.impl.View
	{
		public UIToggle toggle;

		public GameObject wg_active;

		public UILabel lb_tab;

		public ChestTabType tabType;

		private bool sendSignal;

		private bool isBlockedForUpgrade;

		public Action<ChestTabType> onSelect;

		protected override void Awake()
		{
		}

		public void Init(ChestTabType tabType, Action<ChestTabType> onSelect)
		{
		}

		public void UpdateTabText()
		{
		}

		public void OnChangeTab(ChestTabType tabType)
		{
		}

		public void onChange()
		{
		}

		private void Select(GameObject o)
		{
		}

		public string TextName(ChestTabType tabType)
		{
			return null;
		}

		private string RuneTabName(string localizeName, RuneType type)
		{
			return null;
		}

		private string ForgeRuneTabName(string localizeName)
		{
			return null;
		}

		private int GetQuantityOfRune(RuneType runeType)
		{
			return 0;
		}

		private string CraftingMaterialTabName(string localizeName)
		{
			return null;
		}

		private int GetQuanityOfCraftingMaterial()
		{
			return 0;
		}
	}
}
