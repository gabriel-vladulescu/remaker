using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using Spine;
using Spine.Unity;

namespace Assets.Scripts.Core.Skills
{
	internal class SpineAnimation : Assets.Scripts.Ssar.Combat.HeroStateMachines.Animation
	{
		protected const string SPAWN = "Spawn";

		protected const string IDLE = "Idle";

		protected const string RUN = "Run";

		protected const string DASH = "Dash";

		protected const string JUMP = "Jump";

		protected const string JUMP_LOOP = "JumpLoop";

		protected const string JUMP_FALL = "JumpFall";

		protected const string FALL_LOOP = "FallLoop";

		protected const string FALL_IDLE = "FallIdle";

		protected const string ATTACK1 = "ComboAttack1";

		protected const string ATTACK2 = "ComboAttack2";

		protected const string ATTACK3 = "ComboAttack3";

		protected const string BE_HIT = "Behit";

		protected const string STUN = "Stun";

		protected const string DIE = "Die";

		protected const string SKILL_1 = "Skill1";

		protected const string SKILL_2 = "Skill2";

		private SkeletonAnimation skeletonAnimation;

		private RoutineRunner routineRunner;

		private event SpawnAnimationEnd spawnAnimationEndEvent;

		private event BeHitAnimationEnd beHitAnimationEndEvent;

		private event ComboAttack1AnimationEnd comboAttack1AnimationEndEvent;

		public SpineAnimation(SkeletonAnimation skeletonAnimation, RoutineRunner routineRunner)
		{
		}

		private void PlayAnimation(string name, bool loop)
		{
		}

		private void OnComplete(TrackEntry trackEntry)
		{
		}

		public void PlaySkill1()
		{
		}

		public void PlaySkill2()
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

		public void PlayJump(int skippedFrames = 0)
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

		public float Duration(string name)
		{
			return 0f;
		}

		public void PlaySkill3()
		{
		}

		public void PlaySkill4()
		{
		}

		public void PlaySkill5()
		{
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

		public void Update(float deltaTime)
		{
		}

		public void PlayWindcardAnimation(string aniName)
		{
		}
	}
}
