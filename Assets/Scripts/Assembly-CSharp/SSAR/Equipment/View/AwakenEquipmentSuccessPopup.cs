using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Pet.View;
using SSAR.View;
using UnityEngine;

namespace SSAR.Equipment.View
{
	public class AwakenEquipmentSuccessPopup : BasePopup
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AwakenEquipmentSuccessPopup _003C_003E4__this;

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
			public _003CDelay_003Ed__16(int _003C_003E1__state)
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

		public GameObject detailContainer;

		public GameObject btnClick;

		public GameObject mas;

		public UIPanel detailPane;

		public TweenScale light;

		public TweenScale info;

		private EquipmentInfoContainer equipmentInfoContainer;

		private PetInfoContainer petInfoContainer;

		private UIWidget[] widgets;

		private UIPanel panel;

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

		protected override void ExecuteBack()
		{
		}

		public void Show(EquipmentView equipmentView, IItem equipmentCollectData)
		{
		}

		private AbsItemInfoContainer GetItemInfo(EnhanceItemType type)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__16))]
		private IEnumerator Delay()
		{
			return null;
		}

		private void Init()
		{
		}

		private void Init(AbsItemInfoContainer itemInfoContainer)
		{
		}

		private void DisableWidget(bool disable)
		{
		}

		private void Close(GameObject o)
		{
		}

		private void Close()
		{
		}
	}
}
