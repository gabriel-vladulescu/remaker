using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Equipment.Utils;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using UnityEngine;

public class CosmeticGalleryPopup : BasePopup
{
	private class TabInfo<T, T1> : ITab where T : struct, IComparable, IFormattable, IConvertible where T1 : ICosmeticGalleryTabView<T>
	{
		public T curSelect;

		private readonly GameObject _tabContainer;

		private T1[] tabViews;

		public TabInfo(T defaultValue, Action<T> onSelectTab, GameObject tabContainer)
		{
		}

		public void ActiveTab()
		{
		}

		public void DeactiveTab()
		{
		}
	}

	private interface ITab
	{
		void ActiveTab();

		void DeactiveTab();
	}

	[CompilerGenerated]
	private sealed class _003CDelay_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action action;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDelay_003Ed__25(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public CosmeticGalleryCharacterView CharacterView;

	public CosmeticGalleryInventoryView InventoryView;

	public GameObject resourcesContainer;

	public GameObject mainTabContainer;

	public GameObject recommendSubTabContainer;

	public GameObject setSubTabContainer;

	public GameObject weaponSubTabContainer;

	public GameObject armorSubTabContainer;

	public GameObject wingSubTabContainer;

	private Dictionary<CosmeticGalleryTabType, ITab> dict;

	private TabInfo<CosmeticGalleryTabType, CosmeticGalleryTabView> mainTab;

	protected override void Awake()
	{
	}

	public void Show()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	private static void SendMetric()
	{
	}

	private void InitTab()
	{
	}

	private void SelectRecommendSubTab(CosmeticGalleryRecommendTabType tab)
	{
	}

	private void SelectSetSubTab(CosmeticGallerySetSubTabType tab)
	{
	}

	private void SelectWeaponSubTab(CosmeticGalleryWeaponSubTabType tab)
	{
	}

	private void SelectArmorSubTab(CosmeticGalleryArmorSubTabType tab)
	{
	}

	private void SelectWingSubTab(CosmeticGalleryWingSubTabType tab)
	{
	}

	private void InitResources()
	{
	}

	private void OnChangeTab(CosmeticGalleryTabType tabType)
	{
	}

	private void ShowInventory(ICosmeticGalleryValidator validator, ICosmeticGalleryComparer comparer)
	{
	}

	[IteratorStateMachine(typeof(_003CDelay_003Ed__25))]
	private IEnumerator Delay(Action action)
	{
		return null;
	}
}
