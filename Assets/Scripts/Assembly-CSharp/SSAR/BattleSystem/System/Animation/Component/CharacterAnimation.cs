using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.AI;
using UnityEngine;

namespace SSAR.BattleSystem.System.Animation.Component
{
	public class CharacterAnimation : Assets.Scripts.Ssar.Combat.HeroStateMachines.Animation
	{
		private class AnimationSpeedRatio
		{
			private float origin;

			private float bonus;

			public float Origin => 0f;

			public float Bonus => 0f;

			public AnimationSpeedRatio(float origin, float bonus)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CWaitForSeconds_003Ed__148 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float seconds;

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
			public _003CWaitForSeconds_003Ed__148(int _003C_003E1__state)
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

		private UnityEngine.Animation animation;

		private Transform transform;

		private RoutineRunner routineRunner;

		protected const string SPAWN = "Spawn";

		protected const string IDLE = "Idle";

		protected const string RUN = "Run";

		protected const string DASH = "Dash";

		protected const string DIE = "Die";

		protected const string JUMP = "Idle_Jump";

		protected const string JUMP_2 = "Jump2";

		protected const string JUMP_LOOP = "Jump_Loop";

		protected const string JUMP_FALL = "Jump_Fall";

		protected const string FALL_LOOP = "Fall_Loop";

		protected const string FALL_IDLE = "Fall_Idle";

		protected const string ATTACK1 = "Attack1";

		protected const string ATTACK2 = "Attack2";

		protected const string ATTACK3 = "Attack3";

		protected const string ATTACK4 = "Attack4";

		protected const string BE_HIT = "BeHit";

		protected const string DASH_ATTACK1 = "DashAttack";

		protected const string JUMP_ATTACK1 = "JumpAttack1";

		protected const string JUMP_ATTACK2 = "JumpAttack2";

		protected const string Skill_1 = "Skill1";

		protected const string Skill_2 = "Skill2";

		protected const string Skill_3 = "Skill3";

		protected const string Skill_4 = "Skill4";

		protected const string Skill_5 = "Skill5";

		protected const string Skill_6 = "Skill6";

		protected const string Skill_7 = "Skill7";

		protected const string STUN = "Stun";

		protected const string SHACKLE = "Shackle";

		protected const string KNOCKDOWN = "Knockdown";

		private const float spawn_duration = 1.2f;

		private const float be_hit_duration = 0.167f;

		private const float attack1_duration = 1.1f;

		private const float attack2_duration = 0.8f;

		private const float attack3_duration = 0.933f;

		private const float attack4_duration = 1.133f;

		private const float fall_idle_duration = 2f / 15f;

		private const float jump_duration = 7f / 30f;

		private const float jump_fall_duration = 0.3f;

		private const float dash_attack1_duration = 1.1f;

		private const float dash_attack1_damage_dealing_frame = 11f / 30f;

		private const float jump_attack1_damage_dealing_frame = 11f / 30f;

		private const float jump_attack1_active_frame = 0.6f;

		private const float jump_attack1_duration = 1.1f;

		private const float attack1_damage_dealing_frame = 1f / 3f;

		private const float attack1_active_frame = 0.6f;

		private const float attack2_damage_dealing_frame = 0.2f;

		private const float attack2_active_frame = 7f / 15f;

		private const float attack3_damage_dealing_frame = 4f / 15f;

		private const float attack3_active_frame = 1f / 3f;

		private const float attack4_damage_dealing_frame = 0.5f;

		private const float attack4_active_frame = 1.1333333f;

		private const float dash_until_brake_duration = 0.5f;

		private Action onSpawnEnd;

		private Action onAttack1End;

		private Action onAttack2End;

		private Action onAttack3End;

		private Action onAttack4End;

		private Action onFallLandEnd;

		private Action doNothingAction;

		private bool previousFlip;

		private Dictionary<string, AnimationSpeedRatio> speedByAnimationName;

		private string pausedAnimation;

		private float prePausedAnimationSpeed;

		private UnityEngine.Animation originalAnimation;

		private Dictionary<string, float> originalScaleTimeByAnimationName;

		private Dictionary<string, float> originalSpeedByAnimationName;

		private List<TimerAction> timerActions;

		private List<TimerAction> actionDones;

		private string[] _animationNames;

		private List<string> playingAnimationNames;

		private event SpawnAnimationStart spawnAnimationStartEvent;

		private event SpawnAnimationEnd spawnAnimationEndEvent;

		private event BeHitAnimationEnd beHitAnimationEndEvent;

		private event DieAnimationStart dieAnimationStartEvent;

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

		private event DashBrakeBeginListener dashBrakeBeginListenerEvent;

		public CharacterAnimation(UnityEngine.Animation animation, Transform transform, RoutineRunner routineRunner, Dictionary<string, float> scaleTimeByAnimationName)
		{
			this.animation = animation;
			this.transform = transform;
			this.routineRunner = routineRunner;
			originalAnimation = animation;
			originalScaleTimeByAnimationName = scaleTimeByAnimationName;
			speedByAnimationName = new Dictionary<string, AnimationSpeedRatio>();
			timerActions = new List<TimerAction>();
			actionDones = new List<TimerAction>();
			playingAnimationNames = new List<string>();
		}

		private void AdjustAnimationSpeed(UnityEngine.Animation animation, Dictionary<string, float> scaleTimeByAnimationName, Dictionary<string, AnimationSpeedRatio> speedByAnimationName)
		{
		}

		public void SwitchTo(UnityEngine.Animation animation, Dictionary<string, float> scaleTimeByAnimationName)
		{
			this.animation = animation;
		}

		public void GoBackToOriginalAnimation()
		{
			animation = originalAnimation;
		}

		private IEnumerator WaitForSeconds(float seconds, Action action)
		{
			yield return new WaitForSeconds(seconds);
			if (action != null)
			{
				action();
			}
		}

		private void WaitThenNotify(float seconds, Action notifyAction)
		{
			routineRunner.StartCoroutine(WaitForSeconds(seconds, notifyAction));
		}

		public void Freeze(int frame)
		{
		}

		public void Update(float deltaTime)
		{
		}

		private void PlayClip(string clipName)
		{
			if (animation != null && animation.GetClip(clipName) != null)
			{
				animation.Play(clipName);
			}
		}

		public void PlaySpawn()
		{
			PlayClip("Spawn");
			if (spawnAnimationStartEvent != null)
			{
				spawnAnimationStartEvent(this, EventArgs.Empty);
			}
			WaitThenNotify(spawn_duration, delegate
			{
				if (spawnAnimationEndEvent != null)
				{
					spawnAnimationEndEvent(this, EventArgs.Empty);
				}
			});
		}

		public void ListenToSpawnAnimationStart(SpawnAnimationStart listener)
		{
			spawnAnimationStartEvent += listener;
		}

		public void UnlistenToSpawnAnimationStart(SpawnAnimationStart listener)
		{
			spawnAnimationStartEvent -= listener;
		}

		public void ListenToSpawnAnimationEnd(SpawnAnimationEnd listener)
		{
			spawnAnimationEndEvent += listener;
		}

		public void UnlistenToSpawnAnimationEnd(SpawnAnimationEnd listener)
		{
			spawnAnimationEndEvent -= listener;
		}

		public void PlayIdle()
		{
			PlayClip("Idle");
		}

		public void PlayRun()
		{
			PlayClip("Run");
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

		public virtual void PlaySkill1()
		{
		}

		public void PlaySkill2()
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

		public void PlayWindcardAnimation(string aniName)
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

		public void AdjustCurrentAnimationSpeed(float speed)
		{
		}

		public void AdjustAllAnimationSpeed(float speed)
		{
		}
	}
}
