using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;

namespace SSAR.Shop.View
{
	public abstract class AbsShopContainer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AbsShopContainer _003C_003E4__this;

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
			public _003CDelay_003Ed__5(int _003C_003E1__state)
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

		public UITable table;

		protected List<AbsShopCardView> CardViews;

		private void Awake()
		{
		}

		public void Show()
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__5))]
		private IEnumerator Delay(int count)
		{
			return null;
		}

		public void Hide()
		{
		}

		private void InitTable()
		{
		}

		protected ShopConfig GetShopConfig()
		{
			return null;
		}

		protected abstract void OnAwake();

		protected abstract void OnShow();

		protected abstract void OnHide();

		protected abstract string CardViewPath();

		protected abstract int NumOfRowInstantiate();
	}
}
