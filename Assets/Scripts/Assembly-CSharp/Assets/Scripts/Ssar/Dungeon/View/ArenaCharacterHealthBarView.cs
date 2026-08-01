using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using SSAR.BattleSystem.Damage;
using SSAR.Dungeon.View;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Assets.Scripts.Ssar.Dungeon.View
{
	public class ArenaCharacterHealthBarView : strange.extensions.mediation.impl.View
	{
		[CompilerGenerated]
		private sealed class _003CDelayEnable_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CDelayEnable_003Ed__25(int _003C_003E1__state)
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

		public float duration;

		public float delay;

		public UISprite sp_avatar;

		public UILabel lb_level;

		public UILabel lb_name;

		public UISlider slider;

		public UILabel lb_hp;

		public UITable table_modifier;

		public UISprite sp_drop;

		public TweenSlider TweenSlider;

		public GameObject wg_pet;

		private List<ModifierStatusView> modifierStatusViews;

		private float time;

		private float DELAY_UPDATE;

		private Entity entity;

		private HealthComponent healthComponent;

		private BattlePetView battlePetView;

		private float curHealth;

		private List<ModifierVisualType> visualAvailable;

		protected override void Awake()
		{
		}

		public void Track(MainCharacterData mainCharacterData, Entity entity)
		{
		}

		public void OnSpawnPet(Entity entity)
		{
		}

		public void ChangeToArcaneForm(Entity entity)
		{
		}

		public void UpdateArcaneFormHpBar(Entity entity, float hpProgress)
		{
		}

		public void BackToNormalForm(Entity entity)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayEnable_003Ed__25))]
		private IEnumerator DelayEnable(UISprite sprite)
		{
			return null;
		}

		private void Update()
		{
		}

		private void TrackHp()
		{
		}

		private void TrackStatus(Entity entity)
		{
		}
	}
}
