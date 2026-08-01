using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Combat.Skills.Logic.Trigger;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Input.Model;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public abstract class DefaultSkill : Skill
	{
		[CompilerGenerated]
		private sealed class _003CWaitThenReleaseCastSkill_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CharacterInput ci;

			public int skillOrder;

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
			public _003CWaitThenReleaseCastSkill_003Ed__60(int _003C_003E1__state)
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

		private static Vector3 DEFAULT_VECTOR_3;

		private SkillData skillData;

		private ProjectileFactory projectileFactory;

		private EntityWorld entityWorld;

		private ModifierStatsAdjustment modifierStatsAdjustment;

		private Assets.Scripts.Core.Skills.Environment environment;

		private OnHitTargetListener onHitTargetListener;

		private RoutineRunner routineRunner;

		private Character character;

		private Dictionary<Character, Dictionary<Projectile, DamageInfo>> damageInfosByCharacterAndProjectile;

		private Dictionary<Character, bool> impactSfxByCharacters;

		private Vector3 characterPositionAtTheTimeOfFirstProjectileCreation;

		private Direction characterFacingDirectionAtTheTimeOfFirstProjectileCreation;

		private bool isCharacterFacingDirectionAtTheTimeOfFirstProjectileCreationInitialized;

		private DamageSource damageSource;

		private SkillTriggerController triggerController;

		protected SkillData SkillData => null;

		protected ProjectileFactory ProjectileFactory => null;

		protected EntityWorld EntityWorld => null;

		protected Character Character => null;

		public Assets.Scripts.Core.Skills.Environment Environment => null;

		public DefaultSkill(Dependencies dependencies)
			: base(null, null, null, null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		public override void OnProjectileHitAllies(Projectile projectile, List<Character> hitAllies)
		{
		}

		public override void OnProjectileHitTargetsForFirstTime(Projectile projectile, List<Character> hitTargets)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		public override void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles)
		{
		}

		protected override void OnProjectileFinishEvent(Projectile projectile)
		{
		}

		public override void OnHitWall(EventFrame eventFrame)
		{
		}

		public override void OnDeath(Character attacker)
		{
		}

		protected override void Suicide(EventFrame eventFrame)
		{
		}

		protected virtual float AdjustDamageEachTarget(float currentDamage, Projectile projectile, Character hitTarget)
		{
			return 0f;
		}

		public override List<Projectile> LaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		protected abstract DamageInfo ConstructDamageInfo(EventFrame eventFrame, int hitTargetId, Projectile projectile);

		protected abstract List<Projectile> OnLaunchProjectiles(EventFrame ef);

		protected virtual bool ShouldIgnoreThisHit(EventFrame ef, Projectile projectile, List<Character> hitCharacters)
		{
			return false;
		}

		protected virtual void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}

		public virtual DamageSource GetDamageSource()
		{
			return default(DamageSource);
		}

		protected Vector3 CharacterPositionAtTheTimeOfFirstProjectileCreation()
		{
			return default(Vector3);
		}

		public Direction CharacterFacingDirectionAtTheTimeOfFirstProjectileCreation()
		{
			return default(Direction);
		}

		protected Character FindNearestTarget()
		{
			return null;
		}

		protected override Vector3 TargetPosition(bool ignoreTargetY = false)
		{
			return default(Vector3);
		}

		protected Vector3 TargetPosition(out Character target, bool ignoreTargetY = false)
		{
			target = null;
			return default(Vector3);
		}

		protected override Vector3 DirectionTowardTarget(bool ignoreTargetY = false)
		{
			return default(Vector3);
		}

		public override float[] InputIgnoreWindow()
		{
			return null;
		}

		protected virtual Vector2 DirectionTowardNearestTarget(Vector3 pivotPosition, bool ignoreTargetY = false)
		{
			return default(Vector2);
		}

		protected List<ImmuneType> ShowImmuneTypes(Character hitTargetCharacter)
		{
			return null;
		}

		protected bool IsCharacterCcImmune(Character character)
		{
			return false;
		}

		protected bool IsCharacterDamageImmune(Character character)
		{
			return false;
		}

		private void OnTriggerEvents(List<SkillTriggerData> triggerDatas)
		{
		}

		private void CastSkill(int skillOrder, bool interruptCurrentSkill = true)
		{
		}

		private void CastProjectile(SkillTriggerData triggerData)
		{
		}

		private void CastSpawnMonster(SkillTriggerData triggerData)
		{
		}

		private void AdjustElapse(SkillTriggerData triggerData)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitThenReleaseCastSkill_003Ed__60))]
		private IEnumerator WaitThenReleaseCastSkill(CharacterInput ci, int skillOrder)
		{
			return null;
		}

		private void NotifyHitTargets(List<Character> hitTargets)
		{
		}

		private void PlayImpactSfx()
		{
		}

		private void PlayCameraFxWhenProjectileHitTarget()
		{
		}

		protected void AddModifierInfo(DamageInfo damageInfo)
		{
		}

		private void AddModifierInfoByEventFrame(DamageInfo damageInfo, EventFrame eventFrame)
		{
		}

		private void AddModifierInfo(DamageInfo damageInfo, List<ModifierConfig> modifierConfigs)
		{
		}

		private void Log(string s)
		{
		}

		protected virtual string GetShackleVfxPath()
		{
			return null;
		}

		protected virtual Vector3[] GetProjectilePath()
		{
			return null;
		}

		protected virtual object[] GetProjectileCookies()
		{
			return null;
		}

		protected virtual void SetProjectileCustomTrajectory(Projectile projectile, ProjectileTrajectoryParams trajectoryParams, Direction direction)
		{
		}
	}
}
