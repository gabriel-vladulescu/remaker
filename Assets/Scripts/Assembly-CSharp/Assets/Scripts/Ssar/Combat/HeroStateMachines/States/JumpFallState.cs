using System;
using Assets.Scripts.Core.FiniteStateMachine;
using Assets.Scripts.Core.Skills;
using Checking;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines.States
{
	public class JumpFallState : State
	{
		private UserInput userInput;

		private Animation animation;

		private Movement movement;

		private Event event_;

		private Hero hero;

		private Character character;

		private string jumpSkillId;

		private readonly string jump2ndSkillId;

		private readonly int skippedFramesOfAnimation;

		private string[] animationToQueue;

		private float JUMP_TO_FALL_ANIMATION_OFFSET;

		private const float delayToCheckJumpInput = 0.1f;

		private NotNullReference notNullReference;

		private float jumpDuration;

		private float elapsed;

		private bool isJumping;

		private bool isJumpAnimationEnd;

		private bool isJumpEnd;

		private bool isJumpFallAnimationEnd;

		private bool isFalling;

		private bool isFallEnd;

		private bool isResumeFromOtherState;

		private bool leaveStateImmediately;

		private bool isResumeFromDashState;

		private bool isResumeFromDashAttackState;

		private int delayElapsed;

		private int elapsedFrames;

		private bool shouldQueue;

		public JumpFallState(UserInput userInput, Animation animation, Movement movement, Event event_, Hero hero, Character character, string jumpSkillId, string jump2ndSkillId, int skippedFramesOfAnimation = 0, string[] animationToQueue = null, float jumpToFallAnimationOffset = -1f)
		{
			this.userInput = userInput;
			this.animation = animation;
			this.movement = movement;
			this.event_ = event_;
			this.hero = hero;
			this.character = character;
			this.jumpSkillId = jumpSkillId;
			this.jump2ndSkillId = jump2ndSkillId;
			this.skippedFramesOfAnimation = skippedFramesOfAnimation;
			this.animationToQueue = animationToQueue;
			JUMP_TO_FALL_ANIMATION_OFFSET = jumpToFallAnimationOffset;
		}

		public string Name()
		{
			return StateName.JUMP_FALL;
		}

		public void Execute(float dt, StateMachine stateMachine)
		{
			elapsed += dt;
			if (isFallEnd)
			{
				if (userInput.IsInputRun())
				{
					stateMachine.ChangeStateWithHistory(StateName.RUN);
				}
				else
				{
					stateMachine.ChangeStateWithHistory(StateName.IDLE);
				}
			}
		}

		private void InterruptCurrentJumpSkill()
		{
		}

		private void Reset()
		{
			isJumping = false;
			isJumpAnimationEnd = false;
			isJumpEnd = false;
			isJumpFallAnimationEnd = false;
			isFalling = false;
			isFallEnd = false;
			elapsed = 0f;
		}

		public void Enter(bool resume, string fromStateName)
		{
			Reset();
			isResumeFromOtherState = resume;
			event_.ListenToFallEnd(OnFallEnd);

			if (!resume)
			{
				hero.ConsumeJumpCharge();
				movement.Jump();
				animation.PlayJump(skippedFramesOfAnimation);
				isJumping = true;
			}
		}

		public void Exit()
		{
			event_.UnlistenToFallEnd(OnFallEnd);
		}

		private void OnJumpAnimationEnd(object source, EventArgs args)
		{
			isJumpAnimationEnd = true;
		}

		private void OnJumpFallAnimationEnd(object source, EventArgs args)
		{
			isJumpFallAnimationEnd = true;
		}

		private void OnFallEnd(object source, EventArgs args)
		{
			isFallEnd = true;
		}
	}
}
