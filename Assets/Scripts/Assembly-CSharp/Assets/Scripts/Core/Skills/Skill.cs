using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Skills.Colliders;
using Assets.Scripts.Core.Skills.Dashes;
using Assets.Scripts.Core.Skills.Drags;
using Assets.Scripts.Core.Skills.EventTriggers;
using Assets.Scripts.Core.Skills.ForceStopMoves;
using Assets.Scripts.Core.Skills.Jumps;
using Assets.Scripts.Core.Skills.Materials;
using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Core.Skills.Moves;
using Assets.Scripts.Core.Skills.Parts;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Core.Skills.Teleports;
using Assets.Scripts.Core.Skills.VfxFollowBones;
using Assets.Scripts.Ssar.Combat.Skills;
using Core.Skills.Spawners;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public abstract class Skill
	{
		public interface Config
		{
			float Duration();

			float ChannelingDuration();

			bool IsActiveSkill();
		}

		private BuffFactory buffFactory;

		private Environment environment;

		private MonsterSpawner monsterSpawner;

		private Config config;

		protected List<Projectile> projectiles;

		protected List<EventFrame> pendingEventFrames;

		private List<EventFrame> processedEventFrames;

		private List<Projectile> finishedProjectiles;

		private Dictionary<int, ProjectilePart> projectilesByPart;

		private float elapsed;

		private float duration;

		private float channelingDuration;

		private Character caster;

		private List<Assets.Scripts.Core.Skills.Jumps.Jump> jumps;

		private List<Assets.Scripts.Core.Skills.Moves.MoveTowardDirection> moveTowardDirections;

		private bool isInterrupted;

		private List<Assets.Scripts.Core.Skills.Teleports.Teleport> teleports;

		private List<Assets.Scripts.Core.Skills.Colliders.DisableCollider> disableColliders;

		private List<Assets.Scripts.Core.Skills.Jumps.CornerJump> cornerJumps;

		private List<Assets.Scripts.Core.Skills.Moves.MoveUsingSpeed> moveUsingSpeeds;

		private List<Assets.Scripts.Core.Skills.Moves.FlyUpward> flyUpwards;

		private List<Assets.Scripts.Core.Skills.Drags.Drag> drags;

		protected List<Dash> dashes;

		private List<Assets.Scripts.Core.Skills.VfxFollowBones.VfxFollowBone> vfxFollowBones;

		private List<EventTrigger> eventTriggers;

		private List<Assets.Scripts.Core.Skills.ForceStopMoves.ForceStopMove> forceStopMoves;

		private List<string> pathsOfPlayedSfxs;

		private List<Tuple<Modifier, Character>> characterAndBuff;

		private List<Spawner> spawners;

		private List<Assets.Scripts.Core.Skills.Materials.Material> materials;

		private Action<Skill, Projectile> onCreateProjectile;

		private Action<Skill, Projectile> onRemoveProjectile;

		protected float Elapsed => 0f;

		protected float Duration => 0f;

		protected float ChannelingDuration => 0f;

		protected Skill(BuffFactory buffFactory, Environment environment, MonsterSpawner monsterSpawner, Config config)
		{
		}

		public Character Caster()
		{
			return null;
		}

		public virtual void AddEventTrigger(EventTrigger et)
		{
		}

		public virtual void AddEventFrame(EventFrame eventFrame)
		{
		}

		public virtual void OnCast(Character character)
		{
		}

		public virtual bool IsMoveable()
		{
			return false;
		}

		public virtual bool IsJumpable()
		{
			return false;
		}

		public virtual bool IsInterruptibleWhileChanneling()
		{
			return false;
		}

		public virtual void OnJumpBegin()
		{
		}

		public virtual void OnJumpEnd()
		{
		}

		public void OnPreFinish(Character character)
		{
		}

		public void ListenOnCreateProjectile(Action<Skill, Projectile> onCreateProjectile)
		{
		}

		public void UnlistenOnCreateProjectile(Action<Skill, Projectile> onCreateProjectile)
		{
		}

		public void ListenOnRemoveProjectile(Action<Skill, Projectile> onRemoveProjectile)
		{
		}

		public void UnlistenOnRemoveProjectile(Action<Skill, Projectile> onRemoveProjectile)
		{
		}

		public void CreateProjecttile(Projectile projectile)
		{
		}

		public void RemoveProjectile(Projectile projectile)
		{
		}

		public abstract void OnFinish(Character character);

		public abstract void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets);

		public abstract void OnProjectileHitObstacles(Projectile projectile, List<Obstacle> hitObstacles);

		public virtual void OnProjectileHitAllies(Projectile projectile, List<Character> hitAllies)
		{
		}

		public virtual void OnProjectileHitTargetsForFirstTime(Projectile projectile, List<Character> hitTargets)
		{
		}

		public void OnProjectileFinish(Projectile projectile)
		{
		}

		protected virtual void OnProjectileFinishEvent(Projectile projectile)
		{
		}

		public virtual void OnHitWall(EventFrame eventFrame)
		{
		}

		public virtual void OnDeath(Character attacker)
		{
		}

		public virtual void Update(float dt)
		{
		}

		private void UpdateForceStopMoves(float dt)
		{
		}

		private void UpdateEventTriggers(float dt)
		{
		}

		public void FixedUpdate(float dt)
		{
		}

		protected virtual void OnFixedUpdate(float dt)
		{
		}

		protected void InterruptDashes()
		{
		}

		private void UpdateVfxFollowBones(float dt)
		{
		}

		private void UpdateDashes(float dt)
		{
		}

		private void UpdateDrags(float dt)
		{
		}

		private void UpdateFlyUpwards(float dt)
		{
		}

		private void UpdateMoveUsingSpeeds(float dt)
		{
		}

		private void UpdateCornerJumps(float dt)
		{
		}

		private void UpdateDisableColliders(float dt)
		{
		}

		private void UpdateTeleports(float dt)
		{
		}

		private void UpdateMoveTowardDirections(float dt)
		{
		}

		private void UpdateJumps(float dt)
		{
		}

		private void UpdateSpawners(float dt)
		{
		}

		private void UpdateMaterials(float dt)
		{
		}

		private void TriggerEventFrame(float dt)
		{
		}

		private void PlayAnimation(EventFrame eventFrame)
		{
		}

		protected virtual void Suicide(EventFrame eventFrame)
		{
		}

		private void AdjustForceStopMove(EventFrame ef)
		{
		}

		protected virtual void PlaySfxRandomly(EventFrame ef)
		{
		}

		public void OnProjectileLaunched(Skill bySkill)
		{
		}

		private void PlayVfxFollowBone(EventFrame ef)
		{
		}

		protected virtual void OnVfxFollowBonePlayed(EventFrame ef, List<GameObject> vfxs)
		{
		}

		private void PerformDrag(EventFrame ef)
		{
		}

		private void PerformFlyUpward(EventFrame ef)
		{
		}

		private void PerformMoveUsingSpeed(EventFrame ef)
		{
		}

		private void PerformCornerJump(EventFrame ef)
		{
		}

		private void Buff(EventFrame ef)
		{
		}

		private void PlayCameraFx(EventFrame ef)
		{
		}

		private void DisableCollider(EventFrame ef)
		{
		}

		private void Teleport(EventFrame ef)
		{
		}

		protected virtual void OnPerformTeleport(EventFrame ef)
		{
		}

		private void MoveTowardDirection(EventFrame ef)
		{
		}

		public virtual bool IsFinish()
		{
			return false;
		}

		public virtual bool IsChannelingFinish()
		{
			return false;
		}

		public virtual void PlayMaterial(EventFrame ef)
		{
		}

		public virtual void SpawnMonster(EventFrame ef)
		{
		}

		protected virtual void Move(float dt, float elapsed, EventFrame ef)
		{
		}

		protected virtual bool IgnoreMinSpeedOnAirForDashes()
		{
			return false;
		}

		protected virtual void Jump(EventFrame ef)
		{
		}

		public virtual void Interrupt()
		{
		}

		protected virtual void PlaySfx(EventFrame ef)
		{
		}

		protected abstract void PlayVfx(EventFrame ef);

		public abstract List<Projectile> LaunchProjectiles(EventFrame ef);

		protected virtual Vector3 TargetPosition(bool ignoreTargetY = false)
		{
			return default(Vector3);
		}

		protected virtual Vector3 DirectionTowardTarget(bool ignoreTargetY = false)
		{
			return default(Vector3);
		}

		protected virtual void OnUpdate(float dt)
		{
		}

		protected bool IsInterrupted()
		{
			return false;
		}

		protected void AdjustElapsedTo(float newValue)
		{
		}

		protected virtual void OnMoveTowardDirection(EventFrame ef, Assets.Scripts.Core.Skills.Moves.MoveTowardDirection m)
		{
		}

		protected virtual void OnFlyUpward(EventFrame ef, Assets.Scripts.Core.Skills.Moves.FlyUpward fu)
		{
		}

		protected virtual EventFrame AdjustCameraFxParams(Character caster, EventFrame original)
		{
			return null;
		}

		protected virtual void AdjustTeleportParams(Character caster, EventFrame original)
		{
		}

		public abstract float[] InputIgnoreWindow();

		public void OnBeHit(Character byCaster, bool byWindbox)
		{
		}

		protected virtual void OnBeHitEvent(Character byCaster, bool byWindbox)
		{
		}

		public virtual void OnCasterTakingDamage(float damage)
		{
		}

		public void OnHitTarget(Character target, DamageSource damageSource)
		{
		}

		protected virtual void OnHitTargetEvent(Character target, DamageSource damageSource)
		{
		}

		public virtual void OnSkillCasted(Skill skill)
		{
		}

		protected void ReduceDurationBy(float value)
		{
		}

		public void IncreaseDurationBy(float value)
		{
		}

		protected virtual float OnDurationIncreasedBy(float value, float newDuration)
		{
			return 0f;
		}

		protected void AddProjectile(Projectile projectile)
		{
		}

		private void AddProjectiles(List<Projectile> listProjectiles)
		{
		}

		private void AddProjectileToPart(Projectile projectile)
		{
		}

		private void CleanUpProjectiles()
		{
		}

		private void RemoveProjectileFromPart(Projectile projectile)
		{
		}

		private void UpdateProjectiles(float dt)
		{
		}
	}
}
