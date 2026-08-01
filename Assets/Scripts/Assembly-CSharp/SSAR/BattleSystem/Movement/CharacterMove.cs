using Artemis;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using SSAR.BattleSystem.System.Input.Model;
using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class CharacterMove : Assets.Scripts.Ssar.Combat.HeroStateMachines.Movement
	{
		private CharacterInput input;

		private Entity entity;

		private MovementComponent mc;

		private float originalRunSpeed;

		private float originalRunSpeedInTheAir;

		private GameObject original;

		public CharacterMove(GameObject go, Entity entiy, CharacterInput input, Assets.Scripts.Ssar.Combat.HeroStateMachines.Event @event)
		{
			original = go;
			entity = entiy;
			this.input = input;
			InitValues();
		}

		public void SwitchToGameObject(GameObject go, MovementComponent mc)
		{
			original = go;
			this.mc = mc;
		}

		public bool IsInTheAir()
		{
			return mc != null && mc.MoveState == MoveState.JumpFall;
		}

		public void ChangeJumpXSpeed()
		{
		}

		public void ReturnToOriginalRunSpeed()
		{
			if (mc != null)
			{
				mc.RemoveRunSpeedModifier(0);
			}
		}

		public void Run()
		{
			if (mc == null)
			{
				return;
			}

			Direction direction = mc.Direction;
			RunRequest inputRequest = input != null ? input.RunRequest as RunRequest : null;
			if (inputRequest != null)
			{
				direction = inputRequest.dir;
			}

			RunRequest request = new RunRequest(AccessLevel.UserAccess, mc.runData, direction, true);
			mc.AddMovingRequest(request);
		}

		private void InitValues()
		{
			if (entity != null)
			{
				mc = entity.GetComponent<MovementComponent>();
			}
			originalRunSpeed = mc != null ? mc.OriginalRunSpeed() : 0f;
			originalRunSpeedInTheAir = originalRunSpeed;
		}

		public void Dash()
		{
			if (mc == null || mc.dashData == null)
			{
				return;
			}
			float speed = mc.dashData.DashDuration > 0f ? mc.dashData.DashDistance / mc.dashData.DashDuration : 0f;
			float dirSign = mc.Direction == Direction.Right ? 1f : -1f;
			mc.velocity.x = speed * dirSign;
			mc.SetState(MoveState.Dash);
		}

		public float Jump()
		{
			if (mc == null || mc.jumpData == null)
			{
				return 0f;
			}
			mc.velocity = new Vector2(mc.velocity.x, mc.jumpData.GetVelocityVerticalInitial());
			mc.SetState(MoveState.JumpFall);
			return mc.jumpData.jumpHeight;
		}

		public float JumpDuration()
		{
			return mc != null && mc.jumpData != null ? mc.jumpData.jumpDurationReachMaxHeight : 0f;
		}

		public void ChangePosition(Vector3 newPosition)
		{
			CharacterMediatorComponent mediator = entity != null ? entity.GetComponent<CharacterMediatorComponent>() : null;
			if (mediator != null)
			{
				mediator.Position = newPosition;
			}
		}

		public void DisplaceBy(Vector3 displacement)
		{
			CharacterMediatorComponent mediator = entity != null ? entity.GetComponent<CharacterMediatorComponent>() : null;
			if (mediator != null)
			{
				mediator.Move(displacement);
			}
		}

		public void ForceStop()
		{
			if (mc != null)
			{
				mc.ForceStopMove();
			}
		}

		public void Resume()
		{
			if (mc != null)
			{
				mc.ResumeLastMove();
			}
		}
	}
}
