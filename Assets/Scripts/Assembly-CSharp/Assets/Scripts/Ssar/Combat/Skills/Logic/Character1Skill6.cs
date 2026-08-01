using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character1Skill6 : DefaultMeleeSkill
	{
		private class Tracker
		{
			private float ROTATION_DURATION_IN_SECONDS;

			private Assets.Scripts.Core.Skills.Environment environment;

			private WeaponVfxInfo weaponVfxInfo;

			private ProjectileMovementInfo projectileMovementInfo;

			private Vector2 casterPos;

			private int casterFacingDirection;

			private Transform weapon;

			private bool spawned;

			private bool isRotating;

			private bool isFlying;

			private GameObject vfx;

			private GameObject vfxContainer;

			private GameObject vfxWeapon;

			private GameObject vfxWeaponContainer;

			private Vector2 destination;

			private double finalAngleInRad;

			private Vector2 spawnPos;

			private float elapsedRotation;

			private Vector2 direction;

			private float distance;

			private float elapsedFlying;

			private bool isFinish;

			private float velocity;

			private float elapsed;

			private Quaternion vfxOriginalQuaternion;

			private float elapsedScale;

			private bool isScaling;

			public Tracker(Assets.Scripts.Core.Skills.Environment environment, WeaponVfxInfo weaponVfxInfo, ProjectileMovementInfo projectileMovementInfo, Vector2 casterPos, int casterFacingDirection, Transform weapon)
			{
			}

			public void Update(float dt)
			{
			}

			private void SpawnVfx()
			{
			}
		}

		private class Character1Skill6Trajectory : Projectile.Trajectory
		{
			private Assets.Scripts.Core.Skills.Environment environment;

			public Character1Skill6Trajectory(Assets.Scripts.Core.Skills.Environment environment)
			{
			}

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

		[CompilerGenerated]
		private sealed class _003CLoop_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Character1Skill6 _003C_003E4__this;

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
			public _003CLoop_003Ed__12(int _003C_003E1__state)
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

		private Character1Skill6Info info;

		private Assets.Scripts.Core.Skills.Environment environment;

		private EntityWorld entityWorld;

		private RoutineRunner routineRunner;

		private float elapsed;

		private List<Tracker> trackers;

		private List<EventFrame> processedEventFrames;

		private Vector2 casterPos;

		private Vector2 destination;

		private MainCharacterData mainCharacterData;

		public Character1Skill6(Dependencies dependencies)
			: base(null)
		{
		}

		public override void OnCast(Character character)
		{
		}

		[IteratorStateMachine(typeof(_003CLoop_003Ed__12))]
		private IEnumerator Loop()
		{
			return null;
		}

		private void OnLoop(float dt)
		{
		}

		protected override List<Projectile> OnLaunchProjectiles(EventFrame ef)
		{
			return null;
		}

		protected override void PostModifierInfoAddition(EventFrame ef, DamageInfo damageInfo)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}
	}
}
