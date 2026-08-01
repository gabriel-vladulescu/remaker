using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace SSAR.BattleSystem.AI
{
	public class InTargetSkillProjectileRangeTrigger : AbsTrigger
	{
		private class SimulateProjectile
		{
			public class Info
			{
				public Vector3 pos;

				public Quaternion rotation;

				public Vector3 hitBox;

				public Vector3 direction;

				public Info(Vector3 currentPost, Vector3 previousPos, Vector3 hitBox)
				{
				}
			}

			public Projectile projectile;

			private bool finishInit;

			private Vector3 previousPos;

			private Vector3 currentPos;

			private TimerAction timerAction;

			private Entity entity;

			private readonly Vector2 hitBoxSize;

			private Info info;

			public SimulateProjectile(Projectile projectile, Entity entity, Vector2 hitBoxSize)
			{
			}

			private void GenerateNextPoint()
			{
			}

			public void Update(float deltaTime)
			{
			}

			public bool IsCollision()
			{
				return false;
			}

			public Info GetInfo()
			{
				return null;
			}

			private bool DrawGizmo()
			{
				return false;
			}
		}

		public float pointDeduct;

		public string skillId;

		public Vector2 hitBoxSize;

		private List<SimulateProjectile> projectiles;

		private List<Projectile> removedProjectiles;

		private CharacterMediatorComponent mediatorComponent;

		private DashLeftTargetAction dashLeftTargetAction;

		private bool enableSetDirection;

		public InTargetSkillProjectileRangeTrigger(NewMonsterAIComponent aiComponent, AbsAction action, ActionTriggerConfig config)
			: base(null, null, null)
		{
		}

		private void ResetEnableSetDirection()
		{
		}

		public override bool IsTrigger()
		{
			return false;
		}

		public override void OnTrigger(float deltaTime, ref float point)
		{
		}

		private bool PickDirection(ref Direction ret)
		{
			return false;
		}

		private void ClearProjectile()
		{
		}

		private void OnCreateProjectile(Skill skill, Projectile projectile)
		{
		}

		private void OnRemoveProjectile(Skill skill, Projectile projectile)
		{
		}
	}
}
