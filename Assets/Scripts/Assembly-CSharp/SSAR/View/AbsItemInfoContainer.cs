using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Rune.View;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public abstract class AbsItemInfoContainer : strange.extensions.mediation.impl.View
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AbsItemInfoContainer _003C_003E4__this;

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
			public _003CDelay_003Ed__36(int _003C_003E1__state)
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

		public EquipmentInfoLockButton LockButton;

		public GameObject btn_close;

		public GameObject baseInfoContainer;

		public UITable table_button;

		public UIWidget widgetBottom;

		public GameObject fx;

		private EquipmentSubstatView[] substatViews;

		protected IItem collectData;

		private EquipmentInfoRemoveButton removeButton;

		private EquipmentInfoEnhanceButton enhanceButton;

		private EquipmentInfoEquipButton equipButton;

		private EquipmentInfoSellButton sellButton;

		private EquipmentInfoRuneButton runeButton;

		private EquipmentInfoAwakenButton awakenButton;

		private EquipmentInfoEquipSlotButton equipSlot1Button;

		private EquipmentInfoEquipSlotButton equipSlot2Button;

		private EquipmentInfoAncientEnhanceButton ancientEnhanceButton;

		private Action onClose;

		public bool isShow;

		private bool IsHideAllButton;

		private bool isInit;

		protected override void Awake()
		{
		}

		public void Init()
		{
		}

		public void Show(IItem item, bool updateButton, MainCharacterData mainCharacterData)
		{
		}

		public void Show(IItem item, ShowSubStatParameter[] main, ShowSubStatParameter[] showSubStatParameters, bool updateButton = true, MainCharacterData mainCharacterData = null, bool isPreview = false)
		{
		}

		public void OnLockEquipment(IItem equipmentCollectData)
		{
		}

		public void OnUnlockEquipment(IItem equipmentCollectData)
		{
		}

		public void OnEnhanceEquipment(IItem equipmentCollectData)
		{
		}

		public void ListenerOnClose(Action action)
		{
		}

		public void RemoveListenerOnClose(Action action)
		{
		}

		public void Hide()
		{
		}

		public void UpdateButton(IItem collectData)
		{
		}

		private void InitButtonListener()
		{
		}

		private void ClickClose(GameObject o)
		{
		}

		private void InitButton()
		{
		}

		private void InitFiash()
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__36))]
		private IEnumerator Delay()
		{
			return null;
		}

		protected abstract void OnInit();

		protected abstract void OnShow(IItem item, ShowSubStatParameter[] main, ShowSubStatParameter[] showSubStatParameters, MainCharacterData mainCharacterData, bool isPreview);

		protected abstract EffectPathIndex UpgradeEffectPathIndex();
	}
}
