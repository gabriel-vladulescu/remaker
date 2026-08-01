using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Ssar.Dungeon.View;
using SSAR.BattleSystem.Damage;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.Dungeon.View
{
	public class MainCharacterHealthBarView : strange.extensions.mediation.impl.View
	{
		[CompilerGenerated]
		private sealed class _003CDelayEnable_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UISprite sprite;

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
			public _003CDelayEnable_003Ed__17(int _003C_003E1__state)
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

		public UILabel lb_lv;

		public UISlider slider;

		public UITable table_modifier;

		public GameObject wg_pet;

		public UILabel lb_hpPercent;

		private Entity entity;

		private HealthComponent healthComponent;

		private List<ModifierStatusView> modifierStatusViews;

		private float time;

		private float DELAY_UPDATE;

		private BattlePetView battlePetView;

		private bool enableTrackHp;

		protected override void Awake()
		{
		}

		public void OnSpawnMainCharacter(Entity entity)
		{
		}

		public void OnSpawnPet(Entity entity)
		{
		}

		public void ChangeToArcaneForm(Entity entity)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayEnable_003Ed__17))]
		private IEnumerator DelayEnable(UISprite sprite)
		{
			return null;
		}

		public void UpdateArcaneFormHpBar(Entity entity, float hpProgress)
		{
		}

		public void BackToNormalForm(Entity entity)
		{
		}

		private void Update()
		{
		}

		private void TrackHp()
		{
		}

		private void TrackStatus()
		{
		}
	}
}
