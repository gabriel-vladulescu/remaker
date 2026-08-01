using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Skills.Modifiers;
using SSAR.BattleSystem.Damage;
using UnityEngine;

namespace Assets.Scripts.Core.Skills
{
	public abstract class Character
	{
		public enum CharacterState
		{
			Constructor = int.MinValue,
			Default = 0,
			Knockback = 10,
			Knockdown = 11,
			Root = 20,
			Stun = 30,
			Shackle = 40,
			Petrified = 50,
			Freeze = 60,
			Vanish = 70,
			Immune = 80,
			Immaterial = 90,
			Death = 100
		}

		private static HashSet<ModifierType> DEBUFF_WITHOUT_STATE_CHANGE;

		private static ModifierType[] MODIFIER_WITHOUT_STATE_CHANGE;

		private SkillFactory skillFactory;

		private List<Skill> ongoingSkills;

		private List<Modifier> ongoingModifiers;

		private Dictionary<string, SkillCastingRequirement> skillCastingRequirements;

		private Skill channelingSkill;

		private bool isUnderChanneling;

		private Dictionary<Skill, string> ongoingSkillIdsByOnGoingSkills;

		private Vector3 spawnPosition;

		private Action<Modifier> OnAttachModifier;

		private List<Modifier> jumpPreventionModifiers;

		private List<Modifier> ongoingModifiersCauseStateChange;

		private Skill _skill;

		private Modifier _modifier;

		protected Character(SkillFactory skillFactory)
		{
		}

		public void OnDeath(Character attacker)
		{
		}

		public void OnCharacterDeath(Character deadCharacter)
		{
		}

		public void ListenOnAttachModifier(Action<Modifier> action)
		{
		}

		public void UnListenOnAttachModifier(Action<Modifier> action)
		{
		}

		public void Update(float dt)
		{
		}

		private void StartToCoolSkillDown(string channelingSkillId)
		{
		}

		public void FixedUpdate(float dt)
		{
		}

		public void AddSkillCastingRequirement(string skillId, SkillCastingRequirement requirement)
		{
		}

		public bool AddModifier(Modifier modifier)
		{
			return false;
		}

		public void RemoveModifier(Modifier m)
		{
		}

		public bool SkillId(Skill s, ref string skillId)
		{
			return false;
		}

		private void AddBuff(Modifier modifier)
		{
		}

		private void ReplaceOngoingByNewModifier(Modifier newModifier)
		{
		}

		public Modifier FindOngoingModifierOfType(ModifierType newModifierType)
		{
			return null;
		}

		public Skill CastSkill(string skillId)
		{
			return null;
		}

		public bool IsChannelingSkillMoveable()
		{
			return false;
		}

		public bool IsChannelingSkillJumpable()
		{
			return false;
		}

		public bool IsJumpable()
		{
			return false;
		}

		public void AddJumpPreventionModifier(Modifier m)
		{
		}

		public void RemoveJumpPreventionModifier(Modifier m)
		{
		}

		public bool IsChannelingSkillInterruptible()
		{
			return false;
		}

		public void NotifyJumpBegin()
		{
		}

		public void NotifyJumpEnd()
		{
		}

		public void InterruptChannelingSkill()
		{
		}

		public string ShowChannelingSkillId()
		{
			return null;
		}

		public void InterruptSkill(string skillId)
		{
		}

		public abstract bool IsCanPlayAnimationRunInTheAir();

		public abstract bool IsOnGround();

		public abstract bool IsInTheAir();

		public bool IsChanneling()
		{
			return false;
		}

		internal Skill GetChannelingSkill()
		{
			return null;
		}

		public bool IsSkillCastable(string skillId)
		{
			return false;
		}

		public void InterruptOngoingSkills()
		{
		}

		public void InterruptOngoingModifiers()
		{
		}

		public void InterruptOngoingDebuffModifiers()
		{
		}

		public void InterruptOngoingModifiersOfType(ModifierType type)
		{
		}

		public ICollection<string> OngoingSkills()
		{
			return null;
		}

		public Modifier FindModifierOfHighestRank()
		{
			return null;
		}

		public List<Modifier> GetListModifiers()
		{
			return null;
		}

		public Vector3 SpawnPosition()
		{
			return default(Vector3);
		}

		public SkillFactory SkillFactory()
		{
			return null;
		}

		public void AdjustRemainingOfTimeCooldownByRatio(float value)
		{
		}

		public void CoolAllSkillDown()
		{
		}

		public void ConsumeAllSkillCharges()
		{
		}

		public void AdjustCooldownDurationOfActiveSkills(float value)
		{
		}

		public Dictionary<string, SkillCastingRequirement> GetSkillCastingRequirements()
		{
			return null;
		}

		public SkillCastingRequirement GetSkillCastingRequirement(string skillId)
		{
			return null;
		}

		protected abstract void LeaveSkillState();

		public abstract CharacterState State();

		protected abstract void ChangeToState(CharacterState newState);

		public abstract Vector3 Position();

		public abstract Vector3 TorsoPosition();

		public abstract float FacingDirection();

		public abstract void PlayAnimation(string name);

		public abstract void QueueAnimation(string name);

		public abstract void FreezeAnimation(int frame);

		public abstract AbsHeroData HeroData();

		public abstract string Group();

		public abstract int Id();

		public abstract void Dash(float distance, float duration, float blendTime, bool isInvokedFromEventFrame, bool isFromUserInput, bool ignoreMinSpeedOnAir = false, bool backward = false, AnimationCurve curve = null, float maxSpeed = 0f, bool ignoreMoveDirection = false);

		public abstract void StopDash();

		public abstract void Jump(float height, float durationReachMaxHeight, float distance, float durationLandGround, bool isFromSignatureSkill, float floatingDuration = 0f, bool jumpBackward = false);

		public abstract void InterruptJump();

		public abstract void SetMovingDirectionToLeft();

		public abstract void SetMovingDirectionToRight();

		public abstract void DisplaceBy(Vector3 displacement);

		public abstract void TurnCollider(bool on);

		public abstract void AddAnimationSpeed(string animationName, float bonus);

		public abstract void AdjustCurrentAnimationSpeed(float speed);

		public abstract void AdjustAllAnimationSpeed(float speed);

		public abstract float AnimationDuration(string animationName);

		public abstract void SetAnimationSpeed(float speed);

		public abstract float GetAnimationSpeed();

		public abstract void SetFacingDirectionToLeft();

		public abstract void SetFacingDirectionToRight();

		public abstract void PauseAnimation();

		public abstract void UnpauseAnimation();

		public abstract void SetPosition(Vector3 pos);

		public abstract string CurrentAnimationName();

		public abstract List<string> CurrentAnimationNames();

		public abstract GameObject GameObject();

		public abstract void TurnVisibility(bool on);

		public abstract void SkipFramesOfCurrentPlayingAnimation(int frames);

		public abstract void JumpToFrame(int frame);

		public abstract void TurnParticles(bool on);

		private void CheckSkillIsCastable(string skillId)
		{
		}

		private void CheckSkillCastingRequirementExisted(string skillId)
		{
		}

		private void Notify(Skill skill, string skillId)
		{
		}

		private void NotifySkillChannelingFinish(string skillId)
		{
		}

		public void OnBeHit(Character caster, bool byWindbox)
		{
		}

		public void OnHitTarget(Character target, DamageSource damageSource)
		{
		}

		public void OnProjectileLaunched(Skill skill)
		{
		}

		public void OnTakingDamage(float damage)
		{
		}

		public void OnSkillCasted(Skill skill)
		{
		}
	}
}
