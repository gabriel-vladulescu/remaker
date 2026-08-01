using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class Character3Skill4 : DefaultMeleeSkill
	{
		public new class StandStillTrajectory : Projectile.Trajectory
		{
			private Vector3 position;

			private bool firstUpdate;

			public StandStillTrajectory(Vector3 position)
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

		public class Character3Skill4Info
		{
			public float offsetXAxisFallingFromGate;

			public float timeInSecondsUntilReachBiggestShape;

			public float delayGate2InSeconds;

			public float mapLeftPadding;

			public float mapRightPadding;

			public float invisibleStartTime;

			public float invisibleDuration;
		}

		[CompilerGenerated]
		private sealed class _003CWaitThenInvoke_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float waitTime;

			public Action action;

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
			public _003CWaitThenInvoke_003Ed__27(int _003C_003E1__state)
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

		private Assets.Scripts.Core.Skills.Environment environment;

		private Character3Skill4Info info;

		private RoutineRunner routineRunner;

		private Vector3 teleportRelativePos;

		private Vector3 teleportAndLandOnGroundRelativePos;

		private Vector3 casterPosBeforeTeleport;

		private Vector3 casterPosAfterTeleport;

		private Vector3 casterPosAfterTeleportAndLandOnGround;

		private Vector3 gate1Pos;

		private Vector3 gate2Pos;

		private GameObject gate1Vfx;

		private GameObject gate2Vfx;

		private GameObject gate1ExplosionVfx;

		private GameObject gate2ExplosionVfx;

		private int projectilesCount;

		private Projectile projectile1;

		private Projectile projectile2;

		private VfxToPlay[] vfxToPlays;

		private bool isInvisible;

		private bool isFinish;

		public Character3Skill4(Dependencies dependencies)
			: base(null)
		{
		}

		protected override void OnUpdate(float dt)
		{
		}

		public override void OnCast(Character character)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile)
		{
		}

		protected override void OnPerformTeleport(EventFrame ef)
		{
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}

		protected override VfxToPlay[] ListAllVfxToPlay(EventFrame ef)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CWaitThenInvoke_003Ed__27))]
		private IEnumerator WaitThenInvoke(float waitTime, Action action)
		{
			return null;
		}

		private Vector3 AdjustTeleportPositionAccordingToMap(Character caster, float moveDistanceOnX)
		{
			return default(Vector3);
		}

		private Vector3 ClampToMap(Vector3 pos)
		{
			return default(Vector3);
		}
	}
}
