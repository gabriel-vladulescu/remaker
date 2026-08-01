using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Model;
using Assets.Scripts.Ssar.Rune.View;
using SSAR.Equipment.Model;
using SSAR.View;
using Ssar.Ancient.View;

namespace SSAR.Equipment.View
{
	public class EquipmentInfoContainer : AbsItemInfoContainer
	{
		[CompilerGenerated]
		private sealed class _003CEnableClose_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EquipmentInfoContainer _003C_003E4__this;

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
			public _003CEnableClose_003Ed__35(int _003C_003E1__state)
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

		public UILabel lb_name;

		public UILabel lb_rarityTitle;

		public UILabel lb_mainStatValue;

		public UILabel lb_mainStatTitle;

		public UILabel lb_reforgeCount;

		public UILabel lb_craftName;

		public UILabel lb_chargeCount;

		public UISprite mainArrow;

		public UITable table_substat;

		public UIWidget subStatWidget;

		public UITable tableSkill;

		public UIWidget wgSkill;

		public UIWidget anchorEndSubStats;

		public UIWidget widgetAncient;

		public UITable table_runeSlot;

		public EquipmentRuneSlotView[] RuneSlotViews;

		public UIWidget[] layoutBounds;

		public AncientSkillView ancientSkillView;

		private EquipmentSubstatView[] substatViews;

		private EquipmentSlotView equipmentSlotView;

		private EquipmentSkillView[] equipmentSkillView;

		private new EquipmentCollectData collectData;

		private void ShowSkill(EquipmentCollectData equipmentCollectData, MainCharacterData mainCharacterData)
		{
		}

		private void ShowAncientSkill(EquipmentCollectData equipmentCollectData)
		{
		}

		private void CheckShowRuneSlot()
		{
		}

		private void UpdateMainInfo(ShowSubStatParameter[] parameters, MainCharacterData mainCharacterData)
		{
		}

		private void ShowSubStat(EquipmentSubstatView[] views, ShowSubStatParameter[] showSubStatParameters)
		{
		}

		private void ShowReforge()
		{
		}

		private void ShowOwnerName()
		{
		}

		private void InitSubstats()
		{
		}

		private void InitEquipmentBaseInfoContainer()
		{
		}

		protected override void OnInit()
		{
		}

		protected override void OnShow(IItem item, ShowSubStatParameter[] main, ShowSubStatParameter[] showSubStatParameters, MainCharacterData mainCharacterData, bool isPreview)
		{
		}

		protected override EffectPathIndex UpgradeEffectPathIndex()
		{
			return default(EffectPathIndex);
		}

		private void InitEquipmentSkillView()
		{
		}

		[IteratorStateMachine(typeof(_003CEnableClose_003Ed__35))]
		private IEnumerator EnableClose()
		{
			return null;
		}

		public EquipmentSkillView[] GetEquipmentSkillViews()
		{
			return null;
		}
	}
}
