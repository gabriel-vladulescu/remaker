using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.Equipment.Enum;
using Ssar.Craft.Enum;
using Ssar.Craft.Model;
using UnityEngine;

namespace Ssar.Craft.View
{
	public class CraftableItemListView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CraftableItemListView _003C_003E4__this;

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
			public _003CDelay_003Ed__10(int _003C_003E1__state)
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

		public UITable container;

		public UIScrollView scrollView;

		private GameObject prefab;

		private List<CraftableItemHeaderView> HeaderViews;

		private CraftingTabType tabType;

		private void Awake()
		{
		}

		private Dictionary<string, List<CraftableItem>> GroupData(List<CraftableItem> items)
		{
			return null;
		}

		private void CreateHeaders(int count)
		{
		}

		private void ShowHeader(Dictionary<string, List<CraftableItem>> dictionary)
		{
		}

		private void ResetScrollView()
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__10))]
		private IEnumerator Delay()
		{
			return null;
		}

		private string GetHeaderKey(CraftableItem item)
		{
			return null;
		}

		private string GetHeaderSuffix(EquipmentType equipmentType)
		{
			return null;
		}

		internal void Show(CraftingTabType tabType, List<CraftableItem> items)
		{
		}
	}
}
