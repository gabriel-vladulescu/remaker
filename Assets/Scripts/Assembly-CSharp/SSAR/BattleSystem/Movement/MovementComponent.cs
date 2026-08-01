using System;
using System.Collections.Generic;
using Artemis.Interface;
using UnityEngine;

namespace SSAR.BattleSystem.Movement
{
	public class MovementComponent : IComponent
	{
		public class RunSpeedModifier
		{
			private float value;

			private int id;

			public float Value => value;

			public int Id => id;

			public RunSpeedModifier(float value, int id)
			{
				this.value = value;
				this.id = id;
			}
		}

		public class VelocityModifier
		{
			private int id;

			private Vector2 valueRight;

			private Vector2 valueLeft;

			private HashSet<VelocityModifierType> types;

			public int Id => id;

			public Vector2 ValueRight => valueRight;

			public Vector2 ValueLeft => valueLeft;

			public VelocityModifier(int id, Vector2 valueRight, Vector2 valueLeft, VelocityModifierType[] modifierTypes)
			{
				this.id = id;
				this.valueRight = valueRight;
				this.valueLeft = valueLeft;
				types = new HashSet<VelocityModifierType>(modifierTypes);
			}

			public bool IsType(VelocityModifierType type)
			{
				return types.Contains(type) || types.Contains(VelocityModifierType.All);
			}
		}

		public enum VelocityModifierType
		{
			None = -1,
			All = 0,
			Run = 1,
			Dash = 2,
			Jump = 3
		}

		public RunData runData;

		public JumpData jumpData;

		public JumpData dashJumpData;

		public DashData dashData;

		public bool isDash;

		public bool canDashJump;

		public bool isDashJump;

		public bool ignoreJoystickMove;

		public Vector2 velocity;

		private AbsGravityControl gravityControl;

		public Queue<AbsRequest> movingRequestQueue;

		public AbsRequest AbsRequest;

		public int[] accessLevelCount;

		public AccessLevel minimumAccessLevel;

		private readonly SimpleMovementConfigData originalConfigData;

		private readonly float originalMovementSpeedBonus;

		public Direction Direction;

		public bool notifyFallEnd;

		public bool isApplyGravity;

		public bool cacheIsApplyGravity;

		public int frameDelayToApplyGravity;

		public bool clapmPositionToGround;

		private int dashRemaining;

		public float dashElapsedTime;

		private IState state;

		private MoveState moveState;

		private OnGroundState _onGroundState;

		private JumpFallState _jumpFallState;

		private DashState dashState;

		private Dictionary<MoveState, IState> dictionary;

		private AbsGravityControl defaultGravityControl;

		private bool enable;

		private float maxRunSpeed;

		private int runSpeedModifierId;

		private List<RunSpeedModifier> runSpeedModifiers;

		private int velocityModifierId;

		private List<VelocityModifier> velocityModifiers;

		public bool Movable { get; protected set; }

		public MoveState MoveState => moveState;

		public bool Enable
		{
			get
			{
				return enable;
			}
			set
			{
				enable = value;
			}
		}

		public MovementComponent(SimpleMovementConfigData configData, float movementSpeedBonus, Direction direction, bool movable, bool clampPositionToGround, float maxRunSpeed)
		{
			originalConfigData = configData;
			originalMovementSpeedBonus = movementSpeedBonus;
			Direction = direction;
			Movable = movable;
			clapmPositionToGround = clampPositionToGround;
			this.maxRunSpeed = maxRunSpeed;

			enable = true;
			isApplyGravity = true;
			cacheIsApplyGravity = true;
			velocity = Vector2.zero;
			movingRequestQueue = new Queue<AbsRequest>();
			accessLevelCount = new int[6];
			minimumAccessLevel = AccessLevel.UserAccess;
			runSpeedModifiers = new List<RunSpeedModifier>();
			velocityModifiers = new List<VelocityModifier>();
			runSpeedModifierId = 0;
			velocityModifierId = 0;
			dashRemaining = 0;
			isDash = false;
			isDashJump = false;
			canDashJump = false;

			InitWithConfig(configData, clampPositionToGround, movementSpeedBonus);
			SetupMapState();

			defaultGravityControl = new DefaultGravityControl(jumpData != null ? jumpData.GetGravityFallGround() : 20f);
			gravityControl = defaultGravityControl;
			moveState = MoveState.OnGround;
			state = _onGroundState;
		}

		public void ChangeMovementConfigDataTo(SimpleMovementConfigData newData)
		{
			InitWithConfig(newData, clapmPositionToGround, originalMovementSpeedBonus);
		}

		public void ReturnToOriginalMovementConfigData()
		{
			InitWithConfig(originalConfigData, clapmPositionToGround, originalMovementSpeedBonus);
		}

		public bool IsCanPlayAnimationRuneInTheAir()
		{
			return moveState == MoveState.JumpFall;
		}

		public void UpdateDirection(Direction direction)
		{
			Direction = direction;
		}

		public float OriginalRunSpeed()
		{
			return runData != null ? runData.runSpeed : 0f;
		}

		public RunSpeedModifier AddRunSpeedModifier(float value)
		{
			RunSpeedModifier modifier = new RunSpeedModifier(value, runSpeedModifierId++);
			runSpeedModifiers.Add(modifier);
			return modifier;
		}

		public bool RemoveRunSpeedModifier(int id)
		{
			for (int i = 0; i < runSpeedModifiers.Count; i++)
			{
				if (runSpeedModifiers[i].Id == id)
				{
					runSpeedModifiers.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		public float RunSpeed()
		{
			float speed = OriginalRunSpeed();
			for (int i = 0; i < runSpeedModifiers.Count; i++)
			{
				speed += runSpeedModifiers[i].Value;
			}
			if (maxRunSpeed > 0f)
			{
				speed = Mathf.Min(speed, maxRunSpeed);
			}
			return speed;
		}

		public VelocityModifier AddVelocityModifier(Vector2 valueRight, Vector2 valueLeft, VelocityModifierType[] modifierTypes)
		{
			VelocityModifier modifier = new VelocityModifier(velocityModifierId++, valueRight, valueLeft, modifierTypes);
			velocityModifiers.Add(modifier);
			return modifier;
		}

		public bool RemoveVelocityModifier(int id)
		{
			for (int i = 0; i < velocityModifiers.Count; i++)
			{
				if (velocityModifiers[i].Id == id)
				{
					velocityModifiers.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		public Vector2 GetVelocityModifiedValue(VelocityModifierType type)
		{
			Vector2 result = Vector2.zero;
			for (int i = 0; i < velocityModifiers.Count; i++)
			{
				if (velocityModifiers[i].IsType(type))
				{
					result += Direction == Direction.Right ? velocityModifiers[i].ValueRight : velocityModifiers[i].ValueLeft;
				}
			}
			return result;
		}

		private void InitWithConfig(SimpleMovementConfigData configData, bool clampPositionToGround, float movementSpeedBonus)
		{
			if (configData == null)
			{
				return;
			}

			clapmPositionToGround = clampPositionToGround;
			runData = new RunData().SetData(configData.moveSpeed + movementSpeedBonus);

			MovementConfigData fullConfig = configData as MovementConfigData;
			if (fullConfig != null)
			{
				jumpData = new JumpData().SetData(fullConfig.jumpHeight, fullConfig.jumpDurationMaxHeight, fullConfig.jumpDurationLandGround, fullConfig.jumpDistance);
				dashJumpData = new JumpData().SetData(fullConfig.dashJumpHeight, fullConfig.dashJumpDurationMaxHeight, fullConfig.dashJumpDurationLandGround, fullConfig.dashJumpDistance);
				dashData = new DashData().SetData(fullConfig.dashDistance, fullConfig.dashDuration, fullConfig.dashBlendTime);
			}
		}

		public void DeleteMovingRequest()
		{
			movingRequestQueue.Clear();
			AbsRequest = null;
		}

		public void InterruptJump()
		{
			if (moveState == MoveState.JumpFall)
			{
				SetState(MoveState.OnGround);
			}
		}

		public void AddMovingRequest(AbsRequest request)
		{
			movingRequestQueue.Enqueue(request);
		}

		public void AddAccessLevel(AccessLevel level)
		{
			accessLevelCount[(int)level]++;
			RecalculateMinimumAccessLevel();
		}

		public void RemoveAccessLevel(AccessLevel level)
		{
			if (accessLevelCount[(int)level] > 0)
			{
				accessLevelCount[(int)level]--;
			}
			RecalculateMinimumAccessLevel();
		}

		private void RecalculateMinimumAccessLevel()
		{
			for (int i = accessLevelCount.Length - 1; i >= 0; i--)
			{
				if (accessLevelCount[i] > 0)
				{
					minimumAccessLevel = (AccessLevel)i;
					return;
				}
			}
			minimumAccessLevel = AccessLevel.UserAccess;
		}

		public IState CurState()
		{
			return state;
		}

		public void SetState(MoveState moveState)
		{
			if (state != null)
			{
				state.OnExit();
			}

			this.moveState = moveState;
			state = dictionary[moveState];
			state.OnEnter();

			if (moveState == MoveState.Dash)
			{
				dashElapsedTime = 0f;
			}
		}

		private void SetupMapState()
		{
			_onGroundState = new OnGroundState();
			_jumpFallState = new JumpFallState();
			dashState = new DashState();
			dictionary = new Dictionary<MoveState, IState>
			{
				{ MoveState.OnGround, _onGroundState },
				{ MoveState.JumpFall, _jumpFallState },
				{ MoveState.Dash, dashState }
			};
		}

		public void ListenToEnterJump(Action action)
		{
			_jumpFallState.ListenToEnter(action);
		}

		public void ListenToEnterDash(Action action)
		{
			dashState.ListenToEnter(action);
		}

		public void ListenToExitDash(Action action)
		{
			dashState.ListenToExit(action);
		}

		public void CountDash()
		{
			dashRemaining++;
		}

		public bool CanDash()
		{
			return dashRemaining < MaxDashOnAir();
		}

		public AbsGravityControl GetGravityControl()
		{
			return gravityControl;
		}

		public void SetGravityControl(AbsGravityControl gravityControl)
		{
			this.gravityControl = gravityControl;
		}

		public void ResetToDefaultGravityControl()
		{
			gravityControl = defaultGravityControl;
		}

		public void ForceStopMove()
		{
			cacheIsApplyGravity = isApplyGravity;
			velocity = Vector2.zero;
			DeleteMovingRequest();
		}

		public void ResumeLastMove()
		{
			isApplyGravity = cacheIsApplyGravity;
		}

		public void ResetOnGround()
		{
			velocity.y = 0f;
			dashRemaining = 0;
			SetState(MoveState.OnGround);
			ResetToDefaultGravityControl();
		}

		private void DefaultData()
		{
			velocity = Vector2.zero;
			isDash = false;
			isDashJump = false;
			canDashJump = false;
		}

		private int MaxDashOnAir()
		{
			return 1;
		}

		public static VelocityModifierType Convert(MoveState moveState)
		{
			switch (moveState)
			{
				case MoveState.Dash:
					return VelocityModifierType.Dash;
				case MoveState.JumpFall:
					return VelocityModifierType.Jump;
				default:
					return VelocityModifierType.Run;
			}
		}
	}
}
