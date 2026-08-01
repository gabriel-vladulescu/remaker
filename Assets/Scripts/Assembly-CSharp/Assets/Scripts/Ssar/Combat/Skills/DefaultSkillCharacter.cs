using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Input.Model;
using SSAR.Dungeon.Caching;
using UnityEngine;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class DefaultSkillCharacter : Character
	{
		public delegate void CharacterStateListener(CharacterState state);

		public interface Renderer
		{
			void TurnOn();

			void TurnOff();

			void TurnOnParticles();

			void TurnOffParticles();
		}

		private Assets.Scripts.Ssar.Combat.HeroStateMachines.Animation animation;

		private MovementComponent movementComponent;

		private CharacterMediatorComponent characterMediatorComponent;

		private CachingComponent cachingComponent;

		private AbsHeroData heroData;

		private string group;

		private int id;

		private Assets.Scripts.Ssar.Combat.HeroStateMachines.Event @event;

		private CharacterInput characterInput;

		private CharacterJump characterJump;

		private Renderer renderer;

		private CharacterState state;

		private event CharacterStateListener characterStateListenerEvent;

		public DefaultSkillCharacter(SkillFactory skillFactory, Assets.Scripts.Ssar.Combat.HeroStateMachines.Animation animation, MovementComponent mc, CharacterMediatorComponent cmc, CachingComponent cc, AbsHeroData hd, string g, int id, Assets.Scripts.Ssar.Combat.HeroStateMachines.Event @event, CharacterInput characterInput, CharacterJump characterJump, Renderer r)
			: base(skillFactory)
		{
			this.animation = animation;
			movementComponent = mc;
			characterMediatorComponent = cmc;
			cachingComponent = cc;
			heroData = hd;
			group = g;
			this.id = id;
			this.@event = @event;
			this.characterInput = characterInput;
			this.characterJump = characterJump;
			renderer = r;
			state = CharacterState.Default;
		}

		public void ListenToCharacterState(CharacterStateListener listener)
		{
			characterStateListenerEvent += listener;
		}

		public void UnlistenToCharacterState(CharacterStateListener listener)
		{
			characterStateListenerEvent -= listener;
		}

		protected override void LeaveSkillState()
		{
		}

		public override CharacterState State()
		{
			return state;
		}

		protected override void ChangeToState(CharacterState newState)
		{
			state = newState;
			if (characterStateListenerEvent != null)
			{
				characterStateListenerEvent(newState);
			}
		}

		public override Vector3 Position()
		{
			return characterMediatorComponent.Position;
		}

		public override Vector3 TorsoPosition()
		{
			return characterMediatorComponent.Position;
		}

		public override float FacingDirection()
		{
			return (float)movementComponent.Direction;
		}

		public override bool IsCanPlayAnimationRunInTheAir()
		{
			return movementComponent.IsCanPlayAnimationRuneInTheAir();
		}

		public override bool IsOnGround()
		{
			return movementComponent.MoveState == MoveState.OnGround;
		}

		public override bool IsInTheAir()
		{
			return movementComponent.MoveState == MoveState.JumpFall;
		}

		public override void PlayAnimation(string name)
		{
			switch (name)
			{
				case StateName.IDLE:
					animation.PlayIdle();
					break;
				case StateName.RUN:
					animation.PlayRun();
					break;
				case StateName.SPAWN:
					animation.PlaySpawn();
					break;
				case StateName.DASH:
					animation.PlayDash();
					break;
				case StateName.DIE:
					animation.PlayDie();
					break;
				case StateName.BE_HIT:
					animation.PlayBeHit();
					break;
			}
		}

		public override void QueueAnimation(string name)
		{
			animation.QueueAnimation(name);
		}

		public override void FreezeAnimation(int frame)
		{
			animation.Freeze(frame);
		}

		public override AbsHeroData HeroData()
		{
			return heroData;
		}

		public override string Group()
		{
			return group;
		}

		public override int Id()
		{
			return id;
		}

		public override void Dash(float distance, float duration, float blendTime, bool isInvokedFromEventFrame, bool isFromUserInput, bool ignoreMinSpeedOnAir = false, bool backward = false, AnimationCurve curve = null, float maxSpeed = 0f, bool ignoreMoveDirection = false)
		{
			float speed = duration > 0f ? distance / duration : 0f;
			if (backward)
			{
				speed = -speed;
			}
			float dirSign = movementComponent.Direction == Direction.Right ? 1f : -1f;
			movementComponent.velocity.x = speed * dirSign;
			movementComponent.SetState(MoveState.Dash);
		}

		public override void StopDash()
		{
			movementComponent.velocity.x = 0f;
			movementComponent.SetState(MoveState.OnGround);
		}

		public override void Jump(float h, float drmh, float d, float dlg, bool isFromSignatureSkill, float floatingDuration = 0f, bool jumpBackward = false)
		{
			JumpData jumpData = new JumpData().SetData(h, drmh, dlg, d);
			movementComponent.velocity = new Vector2(movementComponent.velocity.x, jumpData.GetVelocityVerticalInitial());
			movementComponent.SetGravityControl(new JumpGravityControl(jumpData.GetGravityJump(), jumpData.GetGravityFallGround(), floatingDuration));
			movementComponent.SetState(MoveState.JumpFall);
		}

		public override void InterruptJump()
		{
			movementComponent.InterruptJump();
		}

		public override void SetMovingDirectionToLeft()
		{
			movementComponent.UpdateDirection(Direction.Left);
		}

		public override void SetMovingDirectionToRight()
		{
			movementComponent.UpdateDirection(Direction.Right);
		}

		public override void DisplaceBy(Vector3 displacement)
		{
			characterMediatorComponent.Move(displacement);
		}

		public override void TurnCollider(bool on)
		{
		}

		public override void AddAnimationSpeed(string name, float bonus)
		{
			animation.AdjustAnimationSpeed(name, bonus);
		}

		public override void AdjustCurrentAnimationSpeed(float speed)
		{
			animation.AdjustCurrentAnimationSpeed(speed);
		}

		public override void AdjustAllAnimationSpeed(float speed)
		{
			animation.AdjustAllAnimationSpeed(speed);
		}

		public override float AnimationDuration(string animationName)
		{
			return animation.Duration(animationName);
		}

		public override void SetAnimationSpeed(float speed)
		{
			animation.SetTimeScale(speed);
		}

		public override float GetAnimationSpeed()
		{
			return animation.GetTimeScale();
		}

		public override void SetFacingDirectionToLeft()
		{
			movementComponent.UpdateDirection(Direction.Left);
		}

		public override void SetFacingDirectionToRight()
		{
			movementComponent.UpdateDirection(Direction.Right);
		}

		public override void PauseAnimation()
		{
			animation.PauseAnimation();
		}

		public override void UnpauseAnimation()
		{
			animation.UnpauseAnimation();
		}

		public override void SetPosition(Vector3 pos)
		{
			characterMediatorComponent.Position = pos;
		}

		public override string CurrentAnimationName()
		{
			return animation.CurrentAnimationName();
		}

		public override List<string> CurrentAnimationNames()
		{
			return animation.CurrentAnimationNames();
		}

		public override GameObject GameObject()
		{
			return characterMediatorComponent.GetGameObject();
		}

		public override void TurnVisibility(bool on)
		{
			if (renderer == null)
			{
				return;
			}
			if (on)
			{
				renderer.TurnOn();
			}
			else
			{
				renderer.TurnOff();
			}
		}

		public override void SkipFramesOfCurrentPlayingAnimation(int frames)
		{
			animation.SkipFramesOfCurrentPlayingAnimation(frames);
		}

		public override void JumpToFrame(int frame)
		{
			animation.JumpToFrame(frame);
		}

		public override void TurnParticles(bool on)
		{
			if (renderer == null)
			{
				return;
			}
			if (on)
			{
				renderer.TurnOnParticles();
			}
			else
			{
				renderer.TurnOffParticles();
			}
		}
	}
}
