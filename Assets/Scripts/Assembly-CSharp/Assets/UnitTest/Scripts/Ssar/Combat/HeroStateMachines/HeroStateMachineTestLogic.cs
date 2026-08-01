using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Artemis;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using UnityEngine;

namespace Assets.UnitTest.Scripts.Ssar.Combat.HeroStateMachines
{
	public class HeroStateMachineTestLogic : MonoBehaviour
	{
		private class TestUserInput : UserInput
		{
			private bool isInputRun;

			private bool isInputDash;

			private bool isInputJump;

			private bool isInputAttack;

			public void Update(float dt)
			{
			}

			public void LateUpdate()
			{
			}

			public bool IsInputRun()
			{
				return false;
			}

			public bool IsInputDash()
			{
				return false;
			}

			public bool IsInputJump()
			{
				return false;
			}

			public bool IsInputAttack()
			{
				return false;
			}

			public bool IsInputSkill()
			{
				return false;
			}

			public string SkillId()
			{
				return null;
			}

			public bool IsInputRunInOppositeDirection()
			{
				return false;
			}

			public void OnSkillCastingRequestConsumed()
			{
			}

			public bool IsHoldingAttack()
			{
				return false;
			}
		}

		private class TestAnimation : Assets.Scripts.Ssar.Combat.HeroStateMachines.Animation
		{
			private float spawnElapsed;

			private float beHitElapsed;

			private bool beHitAnimationTriggered;

			private float jumpElapsed;

			private bool jumpTriggered;

			private float jumpFallElapsed;

			private bool jumpFallTriggered;

			private bool dashAttack1Triggered;

			private float dashAttack1Elapsed;

			private bool dashAttack1DamageDealingFrameNotified;

			private bool jumpAttack1Triggered;

			private float jumpAttack1Elapsed;

			private bool jumpAttack1DamageDealingFrameNotified;

			private bool jumpAttack1ActiveFrameEndNotified;

			private bool comboAttack1Triggered;

			private float comboAttack1Elapsed;

			private bool comboAttack1DamageDealingFrameNotified;

			private bool comboAttack1ActiveFrameEndNotified;

			private bool comboAttack2Triggered;

			private float comboAttack2Elapsed;

			private bool comboAttack2DamageDealingFrameNotified;

			private bool comboAttack2ActiveFrameEndNotified;

			private bool comboAttack3Triggered;

			private float comboAttack3Elapsed;

			private bool comboAttack3DamageDealingFrameNotified;

			private bool comboAttack3ActiveFrameEndNotified;

			private bool comboAttack4Triggered;

			private float comboAttack4Elapsed;

			private bool comboAttack4DamageDealingFrameNotified;

			private bool comboAttack4ActiveFrameEndNotified;

			private event SpawnAnimationEnd spawnAnimationEndEvent;

			private event BeHitAnimationEnd beHitAnimationEndEvent;

			private event JumpAnimationEnd jumpAnimationEndEvent;

			private event JumpFallAnimationEnd jumpFallAnimationEndEvent;

			private event DashAttack1AnimationEnd dashAttack1AnimationEndEvent;

			private event DashAttack1DamageDealingFrame dashAttack1DamageDealingFrameEvent;

			private event JumpAttack1DamageDealingFrame jumpAttack1DamageDealingFrameEvent;

			private event JumpAttack1ActiveFrameEnd jumpAttack1ActiveFrameEndEvent;

			private event JumpAttack1AnimationEnd jumpAttack1AnimationEndEvent;

			private event ComboAttack1DamageDealingFrame comboAttack1DamageDealingFrameEvent;

			private event ComboAttack1ActiveFrameEnd comboAttack1ActiveFrameEndEvent;

			private event ComboAttack1AnimationEnd comboAttack1AnimationEndEvent;

			private event ComboAttack2DamageDealingFrame comboAttack2DamageDealingFrameEvent;

			private event ComboAttack2ActiveFrameEnd comboAttack2ActiveFrameEndEvent;

			private event ComboAttack2AnimationEnd comboAttack2AnimationEndEvent;

			private event ComboAttack3DamageDealingFrame comboAttack3DamageDealingFrameEvent;

			private event ComboAttack3ActiveFrameEnd comboAttack3ActiveFrameEndEvent;

			private event ComboAttack3AnimationEnd comboAttack3AnimationEndEvent;

			private event ComboAttack4DamageDealingFrame comboAttack4DamageDealingFrameEvent;

			private event ComboAttack4ActiveFrameEnd comboAttack4ActiveFrameEndEvent;

			private event ComboAttack4AnimationEnd comboAttack4AnimationEndEvent;

			public void PlaySkill3()
			{
			}

			public void PlaySkill4()
			{
			}

			public void PlaySkill5()
			{
			}

			public void Update(float dt)
			{
			}

			public void PlaySpawn()
			{
			}

			public void ListenToSpawnAnimationStart(SpawnAnimationStart listener)
			{
			}

			public void ListenToSpawnAnimationEnd(SpawnAnimationEnd listener)
			{
			}

			public void UnlistenToSpawnAnimationStart(SpawnAnimationStart listener)
			{
			}

			public void UnlistenToSpawnAnimationEnd(SpawnAnimationEnd listener)
			{
			}

			public void PlayIdle()
			{
			}

			public void PlayRun()
			{
			}

			public void PlayBeHit()
			{
			}

			public void ListenToBeHitAnimationEnd(BeHitAnimationEnd listener)
			{
			}

			public void UnlistenToBeHitAnimationEnd(BeHitAnimationEnd listener)
			{
			}

			public void PlayDash()
			{
			}

			public void PlayDie()
			{
			}

			public void ListenToDieAnimationStart(DieAnimationStart listener)
			{
			}

			public void UnlistenToDieAnimationStart(DieAnimationStart listener)
			{
			}

			public void PlayJump2()
			{
			}

			public void ListenToJumpAnimationEnd(JumpAnimationEnd listener)
			{
			}

			public void UnlistenToJumpAnimationEnd(JumpAnimationEnd listener)
			{
			}

			public void PlayJump(int skippedFrames = 0)
			{
			}

			public void PlayJumpLoop()
			{
			}

			public void PlayJumpFall()
			{
			}

			public void ListenToJumpFallAnimationEnd(JumpFallAnimationEnd listener)
			{
			}

			public void UnlistenToJumpFallAnimationEnd(JumpFallAnimationEnd listener)
			{
			}

			public void PlayFallLoop()
			{
			}

			public void PlayFallIdle()
			{
			}

			public void PlayDashAttack1()
			{
			}

			public void ListenToDashAttack1AnimationEnd(DashAttack1AnimationEnd listener)
			{
			}

			public void ListenToDashAttack1DamageDealingFrame(DashAttack1DamageDealingFrame listener)
			{
			}

			public void UnlistenToDashAttack1AnimationEnd(DashAttack1AnimationEnd listener)
			{
			}

			public void UnlistenToDashAttack1DamageDealingFrame(DashAttack1DamageDealingFrame listener)
			{
			}

			public void PlayJumpAttack1()
			{
			}

			public void ListenToJumpAttack1DamageDealingFrame(JumpAttack1DamageDealingFrame listener)
			{
			}

			public void UnlistenToJumpAttack1DamageDealingFrame(JumpAttack1DamageDealingFrame listener)
			{
			}

			public void ListenToJumpAttack1ActiveFrameEnd(JumpAttack1ActiveFrameEnd listener)
			{
			}

			public void UnlistenToJumpAttack1ActiveFrameEnd(JumpAttack1ActiveFrameEnd listener)
			{
			}

			public void ListenToJumpAttack1AnimationEnd(JumpAttack1AnimationEnd listener)
			{
			}

			public void UnlistenToJumpAttack1AnimationEnd(JumpAttack1AnimationEnd listener)
			{
			}

			public void PlayJumpAttack2()
			{
			}

			public void PlayComboAttack1()
			{
			}

			public void ListenToComboAttack1DamageDealingFrame(ComboAttack1DamageDealingFrame listener)
			{
			}

			public void UnlistenToComboAttack1DamageDealingFrame(ComboAttack1DamageDealingFrame listener)
			{
			}

			public void ListenToComboAttack1ActiveFrameEnd(ComboAttack1ActiveFrameEnd listener)
			{
			}

			public void UnlistenToComboAttack1ActiveFrameEnd(ComboAttack1ActiveFrameEnd listener)
			{
			}

			public void ListenToComboAttack1AnimationEnd(ComboAttack1AnimationEnd listener)
			{
			}

			public void UnlistenToComboAttack1AnimationEnd(ComboAttack1AnimationEnd listener)
			{
			}

			public void PlayComboAttack2()
			{
			}

			public void ListenToComboAttack2DamageDealingFrame(ComboAttack2DamageDealingFrame listener)
			{
			}

			public void UnlistenToComboAttack2DamageDealingFrame(ComboAttack2DamageDealingFrame listener)
			{
			}

			public void ListenToComboAttack2ActiveFrameEnd(ComboAttack2ActiveFrameEnd listener)
			{
			}

			public void UnlistenToComboAttack2ActiveFrameEnd(ComboAttack2ActiveFrameEnd listener)
			{
			}

			public void ListenToComboAttack2AnimationEnd(ComboAttack2AnimationEnd listener)
			{
			}

			public void UnlistenToComboAttack2AnimationEnd(ComboAttack2AnimationEnd listener)
			{
			}

			public void PlayComboAttack3()
			{
			}

			public void ListenToComboAttack3DamageDealingFrame(ComboAttack3DamageDealingFrame listener)
			{
			}

			public void UnlistenToComboAttack3DamageDealingFrame(ComboAttack3DamageDealingFrame listener)
			{
			}

			public void ListenToComboAttack3ActiveFrameEnd(ComboAttack3ActiveFrameEnd listener)
			{
			}

			public void UnlistenToComboAttack3ActiveFrameEnd(ComboAttack3ActiveFrameEnd listener)
			{
			}

			public void ListenToComboAttack3AnimationEnd(ComboAttack3AnimationEnd listener)
			{
			}

			public void UnlistenToComboAttack3AnimationEnd(ComboAttack3AnimationEnd listener)
			{
			}

			public void PlayComboAttack4()
			{
			}

			public void ListenToComboAttack4DamageDealingFrame(ComboAttack4DamageDealingFrame listener)
			{
			}

			public void UnlistenToComboAttack4DamageDealingFrame(ComboAttack4DamageDealingFrame listener)
			{
			}

			public void ListenToComboAttack4ActiveFrameEnd(ComboAttack4ActiveFrameEnd listener)
			{
			}

			public void UnlistenToComboAttack4ActiveFrameEnd(ComboAttack4ActiveFrameEnd listener)
			{
			}

			public void ListenToComboAttack4AnimationEnd(ComboAttack4AnimationEnd listener)
			{
			}

			public void UnlistenToComboAttack4AnimationEnd(ComboAttack4AnimationEnd listener)
			{
			}

			public void PlaySkill1()
			{
			}

			public void PlaySkill2()
			{
			}

			public float Duration(string name)
			{
				return 0f;
			}

			public void PlayKnockdown()
			{
			}

			public void PlayStun()
			{
			}

			public void PlayTier1Skill1()
			{
			}

			public void PlaySkill6()
			{
			}

			public void PlaySkill7()
			{
			}

			public void PlayTier1Skill3()
			{
			}

			public void ListenToDashBrakeBegin(DashBrakeBeginListener dashBrakeBeginListener)
			{
			}

			public void UnlistenToDashBrakeBegin(DashBrakeBeginListener dashBrakeBeginListener)
			{
			}

			public void AdjustAnimationSpeed(string animationName, float bonus)
			{
			}

			public void AdjustCurrentAnimationSpeed(float speed)
			{
			}

			public void AdjustAllAnimationSpeed(float speed)
			{
			}

			public void SetTimeScale(float speed)
			{
			}

			public float GetTimeScale()
			{
				return 0f;
			}

			public void SkipFramesOfCurrentPlayingAnimation(int frames)
			{
			}

			public void JumpToFrame(int frame)
			{
			}

			public void PlayShackle()
			{
			}

			public void PauseAnimation()
			{
			}

			public void UnpauseAnimation()
			{
			}

			public string CurrentAnimationName()
			{
				return null;
			}

			public List<string> CurrentAnimationNames()
			{
				return null;
			}

			public void QueueAnimation(string animationName)
			{
			}

			public void Freeze(int frame)
			{
			}

			public void PlayWindcardAnimation(string aniName)
			{
			}
		}

		private class TestMovement : Movement
		{
			private TestEvent event_;

			private bool isDashing;

			private float dashingElapsed;

			private bool isJumping;

			private float jumpingElapsed;

			private bool dashWhileJump;

			private GameObject position;

			public TestMovement(TestEvent @event)
			{
			}

			public void Run()
			{
			}

			public void Dash()
			{
			}

			public float Jump()
			{
				return 0f;
			}

			public float JumpDuration()
			{
				return 0f;
			}

			public void ChangePosition(Vector3 newPosition)
			{
			}

			public void DisplaceBy(Vector3 displacement)
			{
			}

			public void ForceStop()
			{
			}

			public void Resume()
			{
			}

			public void Update(float dt)
			{
			}

			public bool IsInTheAir()
			{
				return false;
			}

			public void ChangeJumpXSpeed()
			{
			}

			public void ReturnToOriginalRunSpeed()
			{
			}
		}

		private class TestEvent : Assets.Scripts.Ssar.Combat.HeroStateMachines.Event
		{
			private bool beHit;

			private event BeHitListener beHitEvent;

			private event DashEndListener dashEndEvent;

			private event FallEndListener fallEndEvent;

			public void Update(float dt)
			{
			}

			public void LateUpdate()
			{
			}

			private void Input()
			{
			}

			public void ListenToBeHit(BeHitListener listener)
			{
			}

			public void UnlistenToBeHit(BeHitListener listener)
			{
			}

			public void NotifyBeHit(object source, EventArgs args)
			{
			}

			public void ListenToDashEnd(DashEndListener dashEndListener)
			{
			}

			public void UnlistenToDashEnd(DashEndListener dashEndListener)
			{
			}

			public void NotifyDashEnd(object source, EventArgs args)
			{
			}

			public void ListenToFallEnd(FallEndListener listener)
			{
			}

			public void UnlistenToFallEnd(FallEndListener listener)
			{
			}

			public void NotifyFallEnd(object source, EventArgs args)
			{
			}

			public void ListenToDie(DieListener listener)
			{
			}

			public void UnlistenToDie(DieListener listener)
			{
			}

			public void NotifyDie(object source, EventArgs args)
			{
			}

			public void ListenToModifierState(ModifierStateListener listener)
			{
			}

			public void UnlistenToModifierState(ModifierStateListener listener)
			{
			}

			public void NotifyModifierState(object source, EventArgs args)
			{
			}

			public void ListenToResurrection(ResurrectionListener listener)
			{
			}

			public void UnlistenToResurrection(ResurrectionListener listener)
			{
			}

			public void NotifyResurrection(object source, EventArgs args)
			{
			}
		}

		private class TestHero : Hero
		{
			private int remainingCharge;

			public bool HasEnoughJumpCharge()
			{
				return false;
			}

			public void ConsumeJumpCharge()
			{
			}

			public void ConsumeJumpAttack1Charge()
			{
			}

			public void RecoverCharge()
			{
			}

			public int JumpOrder()
			{
				return 0;
			}

			public Vector3 Position()
			{
				return default(Vector3);
			}

			public Entity Entity()
			{
				return null;
			}

			public int FacingDirection()
			{
				return 0;
			}

			public string Group()
			{
				return null;
			}

			public int GetAttackPower()
			{
				return 0;
			}

			public void FaceOppositeDirection()
			{
			}

			public bool IsComboAttack2Available()
			{
				return false;
			}

			public bool IsComboAttack3Available()
			{
				return false;
			}

			public bool IsComboAttack4Available()
			{
				return false;
			}

			public bool IsDashAttackAvailable()
			{
				return false;
			}

			public bool IsJumpAttack1Available()
			{
				return false;
			}

			public bool IsJumpAttack2Available()
			{
				return false;
			}

			public bool IsDashAvailable()
			{
				return false;
			}

			public bool IsJumpAvailable()
			{
				return false;
			}
		}

		private HeroStateMachine heroStateMachine;

		private TestUserInput userInput;

		private TestAnimation animation;

		private TestMovement movement;

		private TestEvent event_;

		private TestHero hero;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
