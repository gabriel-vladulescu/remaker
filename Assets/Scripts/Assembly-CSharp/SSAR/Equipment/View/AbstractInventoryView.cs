using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Equipment.Command;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public abstract class AbstractInventoryView : strange.extensions.mediation.impl.View
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AbstractInventoryView _003C_003E4__this;

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

		public InventoryRowWrapContent wraptContent;

		public UIWidget inventoryRect;

		private UIScrollView scrollView;

		private ShowInventoryParameter parameter;

		public List<ICollectData> collectdata;

		private bool hasShow;

		protected override void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		public void Show(List<ICollectData> collectData, ShowInventoryParameter parameter)
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

		public int CalculateRowCount(int value)
		{
			return 0;
		}

		public List<ICollectData> GetRowData(List<ICollectData> collectData, int rowIndex)
		{
			return null;
		}

		protected virtual void OnUpdate()
		{
		}

		protected abstract void OnShowInventory(List<ICollectData> collectData, ShowInventoryParameter parameter);

		public abstract string GetRowPath();

		protected abstract int GetNumChildOfRow();
	}
}
