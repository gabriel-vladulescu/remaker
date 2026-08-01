using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.EntityTemplate;
using SSAR.BattleSystem.Input;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character3Skill8 : DefaultMeleeSkill
	{
		public class Info
		{
			public float durationReductionPerHit;

			public float durationReductionPerHitByWindbox;

			public string passiveSkillId;

			public float transformToArcaneAt;

			public float hideQuinnAt;

			public float delayQuinnAppearanceBy;
		}

		[CompilerGenerated]
		private sealed class _003CWaitThenShowQuinn_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Character3Skill8 _003C_003E4__this;

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
			public _003CWaitThenShowQuinn_003Ed__22(int _003C_003E1__state)
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

		private Info info;

		private RoutineRunner routineRunner;

		private EventFrame prefabEventFrame;

		private EventFrame transformBackToNormalEventFrame;

		private MainCharacterTemplate.Character3Skill8Swap swap;

		private Vector3 originalPos;

		private Entity entity;

		private Skill passiveSkill;

		private SSAR.BattleSystem.Input.ActionType inputAttack;

		private SSAR.BattleSystem.Input.ActionType inputSkill;

		private SSAR.BattleSystem.Input.ActionType inputDash;

		private InputMappingDataManager imdm;

		private Vector3 casterPositionAtFinish;

		private List<TimelineEvent> timelineEvents;

		private float skillDuration;

		public Character3Skill8(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}

		private void UpdateDurationBar(Entity entity)
		{
		}

		public override void OnFinish(Character character)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenShowQuinn_003Ed__22))]
		private IEnumerator WaitThenShowQuinn()
		{
			return null;
		}

		protected override void OnBeHitEvent(Character byCaster, bool byWindbox)
		{
		}

		protected override float OnDurationIncreasedBy(float value, float newDuration)
		{
			return 0f;
		}
	}
}
