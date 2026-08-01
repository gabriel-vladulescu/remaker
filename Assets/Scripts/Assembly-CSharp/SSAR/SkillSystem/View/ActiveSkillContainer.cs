using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Scripts.Config;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.SkillSystem.View
{
	public class ActiveSkillContainer : strange.extensions.mediation.impl.View
	{
		[CompilerGenerated]
		private sealed class _003CDelay_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ActiveSkillContainer _003C_003E4__this;

			public Preset preset;

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
			public _003CDelay_003Ed__15(int _003C_003E1__state)
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

		public ActiveSkillDescriptionContainer ActiveSkillDescriptionContainer;

		public ActiveSkillRuneContainer ActiveSkillRuneContainer;

		public UITable table_skill;

		public GameObject wg_WeaponSkill;

		public UILabel lb_weaponSkill;

		private List<ActiveSkillItemView> activeSkillItemViews;

		private MainCharacterData mainCharacterData;

		private int skillIdSelected;

		private HeroConfig heroConfig;

		private JsonEquipmentDropConfig jsonEquipmentDropConfig;

		private bool allowEdit;

		private Preset preset;

		protected override void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		public void Show(MainCharacterData mainCharacterData, bool allowEdit, Preset preset)
		{
		}

		[IteratorStateMachine(typeof(_003CDelay_003Ed__15))]
		private IEnumerator Delay(Preset preset)
		{
			return null;
		}

		public void Hide()
		{
		}

		public void UpdateData(Preset preset)
		{
		}

		private void InitSkillitem()
		{
		}

		private void SelectSkill(int skillId)
		{
		}

		private void UpdateWeaponSkillStats(CharacterActiveSkillStat characterActiveSkillStat)
		{
		}
	}
}
