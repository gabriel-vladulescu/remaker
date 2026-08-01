using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;
using SSAR.BattleSystem.Gizmo;
using SSAR.BattleSystem.Movement;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Character2
{
	public class Character2Skill8 : DefaultMeleeSkill
	{
		public class Info
		{
			public float duration;

			public float interval;

			public float delayFromGhostAnimationStartToDamageDealing;

			public string autoFindTargetMode;

			public int numberOfTarget;

			public float radiusToFindTarget;

			public float delayBetweenTargetAttack;

			public Vector2 ghostVfxOffset;

			public float maxSpeed;

			public float maxAcceleration;

			public bool ghostWillIgnoreYAxis;

			public AutoFindTargetMode ShowAutoFindTargetMode()
			{
				return default(AutoFindTargetMode);
			}
		}

		public enum AutoFindTargetMode
		{
			Nearest = 0,
			Random = 1
		}

		private class VfxFollowTarget
		{
			protected float maxSpeed;

			protected float maxAcceleration;

			protected Character target;

			protected GameObject vfx;

			protected Vector2 vfxOffset;

			protected Vector3 startPos;

			protected float elapsed;

			protected bool stop;

			protected Vector2 velocity;

			protected Vector2 previousVelocity;

			protected Direction facingDirection;

			protected Vector3 previousPos;

			protected float targetRadius;

			public VfxFollowTarget(Character target, GameObject vfx, Vector2 vfxOffset, float maxSpeed, float maxAcceleration)
			{
			}

			private void OffsetChildToLeft()
			{
			}

			private void OffsetChildToRight()
			{
			}

			private void FaceLeft()
			{
			}

			private void FaceRight()
			{
			}

			public virtual void Update(float dt)
			{
			}

			public void Stop()
			{
			}

			public Vector3 Velocity()
			{
				return default(Vector3);
			}

			public virtual Vector3 Position()
			{
				return default(Vector3);
			}
		}

		private class VfxFollowTarget2 : VfxFollowTarget
		{
			private float T;

			private Vector2 previousDirection;

			private float t;

			private bool ignoreYAxis;

			public VfxFollowTarget2(Character target, GameObject vfx, Vector2 vfxOffset, float maxSpeed, float maxAcceleration, bool ignoreYAxis)
				: base(target, vfx, vfxOffset, maxSpeed, maxAcceleration)
			{
			}

			public override void Update(float dt)
			{
			}

			public override Vector3 Position()
			{
				return default(Vector3);
			}
		}

		private class FollowTargetTrajectory : Projectile.Trajectory
		{
			private Vector3 OFFSET;

			private Character target;

			private GameObject vfx;

			public FollowTargetTrajectory(Character target, GameObject vfx)
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

		private new class StandStillTrajectory : Projectile.Trajectory
		{
			private Vector3 pos;

			public StandStillTrajectory(Vector3 pos)
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
		private sealed class _003CHighlightTarget_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Character target;

			private SphereShape _003Css_003E5__2;

			private float _003Celapsed_003E5__3;

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
			public _003CHighlightTarget_003Ed__16(int _003C_003E1__state)
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

		private Assets.Scripts.Core.Skills.Environment environment;

		private EventFrame originalGhostVfxFrame;

		private List<SsarWaitForSeconds> waits;

		private Dictionary<EventFrame, Character> targetByEventFrame;

		private List<VfxFollowTarget> vfxFollowTargets;

		private Dictionary<EventFrame, EventFrame> vfxEventFrameByDamageEventFrame;

		private Dictionary<EventFrame, GameObject> vfxByVfxEventFrame;

		private Dictionary<EventFrame, VfxFollowTarget> vfxFollowTargetByVfxEventFrame;

		public Character2Skill8(Dependencies dependencies)
			: base(null)
		{
		}

		public override void AddEventFrame(EventFrame eventFrame)
		{
		}

		protected override void OnVfxPlayed(EventFrame fromEventFrame, int vfxId, GameObject vfx)
		{
		}

		public override void Update(float dt)
		{
		}

		protected override void OnProjectileCreated(Projectile projectile)
		{
		}

		private bool IsEventFrameGhostVfx(EventFrame ef)
		{
			return false;
		}

		private void FindTargetsPosThenCreateExtraFrames(object eventFrame)
		{
		}

		[IteratorStateMachine(typeof(_003CHighlightTarget_003Ed__16))]
		private IEnumerator HighlightTarget(Character target)
		{
			return null;
		}

		private object[] FindTargetsPosition()
		{
			return null;
		}

		private EventFrame CloneOriginalGhostVfxFrame(float frame)
		{
			return null;
		}

		private EventFrame CloneOriginalDamageFrame(EventFrame originalDamageFrame, float frame)
		{
			return null;
		}

		private void WaitThenInvoke(float waitTime, Action<object> callback, object obj)
		{
		}
	}
}
