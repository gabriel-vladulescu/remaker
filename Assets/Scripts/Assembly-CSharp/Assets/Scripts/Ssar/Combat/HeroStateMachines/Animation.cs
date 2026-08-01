using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Combat.HeroStateMachines
{
	public interface Animation
	{
		void PlaySpawn();

		void ListenToSpawnAnimationStart(SpawnAnimationStart listener);

		void ListenToSpawnAnimationEnd(SpawnAnimationEnd listener);

		void UnlistenToSpawnAnimationStart(SpawnAnimationStart listener);

		void UnlistenToSpawnAnimationEnd(SpawnAnimationEnd listener);

		void PlayIdle();

		void PlayRun();

		void PlayBeHit();

		void ListenToBeHitAnimationEnd(BeHitAnimationEnd listener);

		void UnlistenToBeHitAnimationEnd(BeHitAnimationEnd listener);

		void PlayDash();

		void PlayDie();

		void ListenToDieAnimationStart(DieAnimationStart listener);

		void UnlistenToDieAnimationStart(DieAnimationStart listener);

		void PlayJump(int skippedFrames = 0);

		void PlayJump2();

		void ListenToJumpAnimationEnd(JumpAnimationEnd listener);

		void UnlistenToJumpAnimationEnd(JumpAnimationEnd listener);

		void PlayJumpLoop();

		void PlayJumpFall();

		void ListenToJumpFallAnimationEnd(JumpFallAnimationEnd listener);

		void UnlistenToJumpFallAnimationEnd(JumpFallAnimationEnd listener);

		void PlayFallLoop();

		void PlayFallIdle();

		void PlayDashAttack1();

		void ListenToDashAttack1AnimationEnd(DashAttack1AnimationEnd listener);

		void ListenToDashAttack1DamageDealingFrame(DashAttack1DamageDealingFrame listener);

		void UnlistenToDashAttack1AnimationEnd(DashAttack1AnimationEnd listener);

		void UnlistenToDashAttack1DamageDealingFrame(DashAttack1DamageDealingFrame listener);

		void PlayJumpAttack1();

		void ListenToJumpAttack1DamageDealingFrame(JumpAttack1DamageDealingFrame listener);

		void UnlistenToJumpAttack1DamageDealingFrame(JumpAttack1DamageDealingFrame listener);

		void ListenToJumpAttack1ActiveFrameEnd(JumpAttack1ActiveFrameEnd listener);

		void UnlistenToJumpAttack1ActiveFrameEnd(JumpAttack1ActiveFrameEnd listener);

		void ListenToJumpAttack1AnimationEnd(JumpAttack1AnimationEnd listener);

		void UnlistenToJumpAttack1AnimationEnd(JumpAttack1AnimationEnd listener);

		void PlayJumpAttack2();

		void PlayComboAttack1();

		void ListenToComboAttack1DamageDealingFrame(ComboAttack1DamageDealingFrame listener);

		void UnlistenToComboAttack1DamageDealingFrame(ComboAttack1DamageDealingFrame listener);

		void ListenToComboAttack1ActiveFrameEnd(ComboAttack1ActiveFrameEnd listener);

		void UnlistenToComboAttack1ActiveFrameEnd(ComboAttack1ActiveFrameEnd listener);

		void ListenToComboAttack1AnimationEnd(ComboAttack1AnimationEnd listener);

		void UnlistenToComboAttack1AnimationEnd(ComboAttack1AnimationEnd listener);

		void PlayComboAttack2();

		void ListenToComboAttack2DamageDealingFrame(ComboAttack2DamageDealingFrame listener);

		void UnlistenToComboAttack2DamageDealingFrame(ComboAttack2DamageDealingFrame listener);

		void ListenToComboAttack2ActiveFrameEnd(ComboAttack2ActiveFrameEnd listener);

		void UnlistenToComboAttack2ActiveFrameEnd(ComboAttack2ActiveFrameEnd listener);

		void ListenToComboAttack2AnimationEnd(ComboAttack2AnimationEnd listener);

		void UnlistenToComboAttack2AnimationEnd(ComboAttack2AnimationEnd listener);

		void PlayComboAttack3();

		void ListenToComboAttack3DamageDealingFrame(ComboAttack3DamageDealingFrame listener);

		void UnlistenToComboAttack3DamageDealingFrame(ComboAttack3DamageDealingFrame listener);

		void ListenToComboAttack3ActiveFrameEnd(ComboAttack3ActiveFrameEnd listener);

		void UnlistenToComboAttack3ActiveFrameEnd(ComboAttack3ActiveFrameEnd listener);

		void ListenToComboAttack3AnimationEnd(ComboAttack3AnimationEnd listener);

		void UnlistenToComboAttack3AnimationEnd(ComboAttack3AnimationEnd listener);

		void PlayComboAttack4();

		void ListenToComboAttack4DamageDealingFrame(ComboAttack4DamageDealingFrame listener);

		void UnlistenToComboAttack4DamageDealingFrame(ComboAttack4DamageDealingFrame listener);

		void ListenToComboAttack4ActiveFrameEnd(ComboAttack4ActiveFrameEnd listener);

		void UnlistenToComboAttack4ActiveFrameEnd(ComboAttack4ActiveFrameEnd listener);

		void ListenToComboAttack4AnimationEnd(ComboAttack4AnimationEnd listener);

		void UnlistenToComboAttack4AnimationEnd(ComboAttack4AnimationEnd listener);

		void PlaySkill1();

		void PlaySkill2();

		float Duration(string name);

		void PlaySkill3();

		void PlaySkill4();

		void PlaySkill5();

		void PlayKnockdown();

		void PlayStun();

		void PlayTier1Skill1();

		void PlaySkill6();

		void PlaySkill7();

		void PlayTier1Skill3();

		void PlayWindcardAnimation(string aniName);

		void ListenToDashBrakeBegin(DashBrakeBeginListener dashBrakeBeginListener);

		void UnlistenToDashBrakeBegin(DashBrakeBeginListener dashBrakeBeginListener);

		void AdjustAnimationSpeed(string animationName, float bonus);

		void AdjustCurrentAnimationSpeed(float speed);

		void AdjustAllAnimationSpeed(float speed);

		void SetTimeScale(float speed);

		float GetTimeScale();

		void SkipFramesOfCurrentPlayingAnimation(int frames);

		void JumpToFrame(int frame);

		void PlayShackle();

		void PauseAnimation();

		void UnpauseAnimation();

		string CurrentAnimationName();

		List<string> CurrentAnimationNames();

		void QueueAnimation(string animationName);

		void Freeze(int frame);

		void Update(float deltaTime);
	}
}
