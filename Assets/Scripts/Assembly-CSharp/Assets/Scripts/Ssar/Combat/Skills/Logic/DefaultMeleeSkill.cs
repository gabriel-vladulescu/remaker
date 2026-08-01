using System;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Gizmo;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Event.Component;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultMeleeSkill : DefaultSkill
	{
		protected class VfxToPlay
		{
			private int id;

			private GameObject go;

			public int Id => 0;

			public GameObject Go => null;

			public VfxToPlay(int id, GameObject go)
			{
			}
		}

		public class StandStillTrajectory : Projectile.Trajectory
		{
			private Vector3 pos;

			private bool isPosInitialized;

			public Direction AdjustCharacterFacingDirectionParam(Direction currentDirection, Direction directionAtTheTimeOfFirstProjectileCreation)
			{
				return default(Direction);
			}

			public Vector3 AdjustCharacterPositionParam(Vector3 currentCharacterPosition, Vector3 characterPositionAtTheTimeOfFirstProjectileCreation)
			{
				return default(Vector3);
			}

			public void Update(float dt, Projectile projectile, Vector3 currentPosition)
			{
			}
		}

		private SkillData skillData;

		private ProjectileFactory projectileFactory;

		private EntityWorld entityWorld;

		private Assets.Scripts.Core.Skills.Environment environment;

		private CharacterEvent characterEvent;

		private Character character;

		private List<GameObject> vfxs;

		private List<GameObject> vfxsAlreadyRecycled;

		private List<GameObject> vfxsFollowCasterPosition;

		private Dictionary<Projectile, GizmoDrawRequest> gizmosDrawRequestByProjectiles;

		public DefaultMeleeSkill(Dependencies dependencies)
			: base(null)
		{
		}

		private void OnFallEnd(object source, EventArgs args)
		{
		}

		public override void OnProjectileHitTargets(Projectile projectile, List<Character> hitTargets)
		{
		}

		private void PlayImpactVfx(Projectile projectile, List<Character> hitTargets)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected virtual void OnUpdateGizmoDrawRequest(Projectile projectile, GizmoDrawRequest drawRequest)
		{
		}

		protected override DamageInfo ConstructDamageInfo(EventFrame eventFrame, int hitTargetId, Projectile projectile)
		{
			return null;
		}

		public override void OnCast(Character character)
		{
		}

		protected virtual void PlayAnimation(Character character)
		{
		}

		protected virtual void OnBeforeFinish()
		{
		}

		public override void OnFinish(Character character)
		{
		}

		public override void Interrupt()
		{
		}

		protected override List<Projectile> OnLaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		protected virtual void OnProjectileCreated(Projectile projectile)
		{
		}

		protected override void PlayVfx(EventFrame ef)
		{
		}

		protected void CleanVfxs()
		{
		}

		protected virtual VfxToPlay[] ListAllVfxToPlay(EventFrame ef)
		{
			return null;
		}

		protected virtual void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}

		protected virtual bool ShouldPlayBeHitVfx(EventFrame eventFrame, Projectile projectile)
		{
			return false;
		}

		private void Log(string s)
		{
		}

		public void ClearGizmosDrawRequests()
		{
		}

		protected ProjectileFactory GetProjectileFactory()
		{
			return null;
		}
	}
}
