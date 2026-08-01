using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SSAR.Equipment.Model;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class CosmeticGalleryInventoryView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitUpdate_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CosmeticGalleryInventoryView _003C_003E4__this;

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
			public _003CWaitUpdate_003Ed__5(int _003C_003E1__state)
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

		public UIScrollView ScrollView;

		public SimpleWrapContent SimpleWrapContent;

		private WraptContentInstantiateChild wraptContentInstantiateChild;

		private void Start()
		{
		}

		public void Show(List<ICosmeticGalleryItemData> itemInfos)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitUpdate_003Ed__5))]
		private IEnumerator WaitUpdate()
		{
			return null;
		}
	}
}
