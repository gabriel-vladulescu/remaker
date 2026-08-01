using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Rune.Enum;
using Assets.Scripts.Ssar.Rune.View;
using SSAR.View;
using Scripts.Config;
using Ssar.Rune.Model;
using UnityEngine;

namespace Assets.Scripts.Mastery
{
	public class MasteryPopup : BasePopup
	{
		[CompilerGenerated]
		private sealed class _003CReEnableBoxItems_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MasteryPopup _003C_003E4__this;

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
			public _003CReEnableBoxItems_003Ed__23(int _003C_003E1__state)
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

		public MasterTableView MasterTableView;

		public TrainMasteryContainer TrainMasteryContainer;

		public MasteryPopupInventoryView InventoryView;

		public GameObject resourcesContainer;

		public RuneInventoryTabView[] RuneInventoryTabViews;

		private RuneInventoryTabType curTab;

		private MainCharacterData mainCharacterData;

		private bool allowEdit;

		private UserResourcesView userResourcesView;

		private ShortCutFindItem shortCutFindItem;

		protected override void Awake()
		{
		}

		protected override void onEnable()
		{
		}

		protected override bool EnableBack()
		{
			return false;
		}

		public void Show(MainCharacterData mainCharacterData, bool allowEdit)
		{
		}

		private void InitResources()
		{
		}

		private void InitTab()
		{
		}

		private void ShowTab()
		{
		}

		public void ShowInventoryWithTab(RuneInventoryTabType tabType)
		{
		}

		public void UpdateInventory()
		{
		}

		public void UpdateData()
		{
		}

		public void SelectMasteryToTrain(MasteryInfo masteryInfo)
		{
		}

		private RuneInventoryTabType GetInventoryTab(RuneType runeType)
		{
			return default(RuneInventoryTabType);
		}

		public void HideTrainMasteryContainer()
		{
		}

		[IteratorStateMachine(typeof(_003CReEnableBoxItems_003Ed__23))]
		private IEnumerator ReEnableBoxItems()
		{
			return null;
		}

		public void AddMaterial()
		{
		}

		public void RemoveMaterial()
		{
		}

		public void TrainSuccess()
		{
		}

		private void InitShortCutFindItem()
		{
		}

		private void CheckEnableShortCut()
		{
		}
	}
}
