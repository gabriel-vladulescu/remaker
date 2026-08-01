using Artemis;
using Artemis.System;
using SSAR.BattleSystem.System.Event.Component;
using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class MovementSystem : EntityProcessingSystemWithTime
	{
		public static float GROUND_VELOCITY_MAGIC_NUMBER;

		private MovementInfluenceByEnvironmentConfig movementInfluenceByEnvironmentConfig;

		private int frame;

		public bool enableUpdate;

		public MovementSystem(bool subscribeSimTime)
			: base(Aspect.All(typeof(MovementComponent), typeof(CharacterMediatorComponent)), subscribeSimTime)
		{
			enableUpdate = true;
			frame = 0;
		}

		public void SetMoveementInfluenceByEnvironmentConfig(MovementInfluenceByEnvironmentConfig config)
		{
			movementInfluenceByEnvironmentConfig = config;
		}

		public override void Process()
		{
			if (!enableUpdate)
			{
				return;
			}
			frame++;
			base.Process();
		}

		protected override void Process(Entity entity, float deltaTime)
		{
			MovementComponent movementComponent = entity.GetComponent<MovementComponent>();
			CharacterMediatorComponent characterMediator = entity.GetComponent<CharacterMediatorComponent>();

			if (movementComponent == null || characterMediator == null || !movementComponent.Enable)
			{
				return;
			}

			ProcessMovingRequestQueue(movementComponent, entity);

			if (movementComponent.isApplyGravity)
			{
				ApplyGravity(movementComponent, characterMediator, deltaTime);
			}

			Move(entity, movementComponent, characterMediator, deltaTime);

			CharacterEventComponent characterEventComponent = entity.GetComponent<CharacterEventComponent>();
			CheckGround(movementComponent, characterMediator, characterEventComponent);
			CheckDashEnd(movementComponent, characterEventComponent, deltaTime);
		}

		private void CheckDashEnd(MovementComponent movementComponent, CharacterEventComponent characterEventComponent, float deltaTime)
		{
			if (movementComponent.MoveState != MoveState.Dash || movementComponent.dashData == null)
			{
				return;
			}

			movementComponent.dashElapsedTime += deltaTime;
			if (movementComponent.dashElapsedTime >= movementComponent.dashData.DashDuration)
			{
				movementComponent.velocity.x = 0f;
				movementComponent.SetState(MoveState.OnGround);
				if (characterEventComponent != null)
				{
					characterEventComponent.NotifyExitDash();
				}
			}
		}

		private void ApplyGravity(MovementComponent movementComponent, CharacterMediatorComponent _characterMediator, float deltaTime)
		{
			if (movementComponent.MoveState == MoveState.OnGround && _characterMediator.IsGrounded)
			{
				movementComponent.velocity.y = 0f;
				return;
			}

			AbsGravityControl gravityControl = movementComponent.GetGravityControl();
			movementComponent.velocity.y = gravityControl.CalculateVelocityVertical(movementComponent.velocity.y, deltaTime);
		}

		private void Move(Entity entity, MovementComponent movementComponent, CharacterMediatorComponent _characterMediator, float detalTime)
		{
			Vector2 velocity = movementComponent.velocity;
			Vector3 delta = new Vector3(velocity.x * detalTime, velocity.y * detalTime, 0f);
			_characterMediator.Move(delta);
		}

		private void CheckGround(MovementComponent movementComponent, CharacterMediatorComponent characterMediatorComponent, CharacterEventComponent characterEventComponent)
		{
			bool grounded = characterMediatorComponent.IsGrounded;

			if (grounded && movementComponent.MoveState == MoveState.JumpFall && movementComponent.velocity.y <= 0f)
			{
				movementComponent.ResetOnGround();
				if (characterEventComponent != null)
				{
					characterEventComponent.NotifyExitfall();
				}
			}
			else if (!grounded && movementComponent.MoveState == MoveState.OnGround)
			{
				movementComponent.SetState(MoveState.JumpFall);
			}
		}

		private void ProcessMovingRequestQueue(MovementComponent move, Entity e)
		{
			while (move.movingRequestQueue.Count > 0)
			{
				AbsRequest next = move.movingRequestQueue.Dequeue();
				if (IsUsableMovingRequest(next, move))
				{
					if (move.AbsRequest != null)
					{
						OnExitRequest(e, move.AbsRequest);
					}
					move.AbsRequest = next;
					next.Attach(e);
					next.OnAttach();
				}
			}

			if (move.AbsRequest != null)
			{
				move.AbsRequest.Update(Time.deltaTime);
				if (move.AbsRequest.Expired())
				{
					OnExitRequest(e, move.AbsRequest);
					move.AbsRequest = null;
				}
			}
		}

		private bool IsUsableMovingRequest(AbsRequest request, MovementComponent move)
		{
			return (int)request.AccessLevel >= (int)move.minimumAccessLevel;
		}

		private void CheckStatusAndRemoveRequest(Entity e)
		{
			MovementComponent move = e.GetComponent<MovementComponent>();
			if (move != null && move.AbsRequest != null && move.AbsRequest.Expired())
			{
				OnExitRequest(e, move.AbsRequest);
				move.AbsRequest = null;
			}
		}

		private void OnExitRequest(Entity e, AbsRequest request)
		{
			request.Exit();
		}
	}
}
