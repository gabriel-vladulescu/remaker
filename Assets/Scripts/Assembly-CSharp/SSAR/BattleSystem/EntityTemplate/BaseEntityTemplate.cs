using System.Collections.Generic;
using Artemis;
using Artemis.Attributes;
using Artemis.Interface;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Combat.Skills;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Animation.Component;
using SSAR.BattleSystem.System.Input.Model;
using SSAR.Dungeon.Caching;
using Scripts.Config;
using Scripts.Config.Stats;
using Spine.Unity;
using UnityEngine;

namespace SSAR.BattleSystem.EntityTemplate
{
	[ArtemisEntityTemplate("Hero")]
	public abstract class BaseEntityTemplate : IEntityTemplate
	{
		public const string Name = "Hero";

		protected BaseHeroTemplateArgs args;

		public Entity BuildEntity(Entity entity, EntityWorld entityWorld, params object[] args)
		{
			BaseHeroTemplateArgs heroArgs = args != null && args.Length > 0 ? args[0] as BaseHeroTemplateArgs : null;
			this.args = heroArgs;

			Base(entity, args);

			if (heroArgs != null)
			{
				OnBuild(entity, heroArgs);
				FinishSetupBase(entity, heroArgs);
				OverrideSetupFromPrefab(entity, heroArgs);
				Final(entity, heroArgs);
			}

			return entity;
		}

		protected void Base(Entity entity, params object[] args)
		{
		}

		protected virtual CharacterInput GetCharacterInput(ConfigManager configManager, int groupId, int subId)
		{
			return new CharacterInput();
		}

		protected int MaxJumpCharge(int groupId)
		{
			return 1;
		}

		protected abstract HeroStateMachine GetHeroStateMachine(GameObject entityGameObject, Entity entity, UserInput userInput, Assets.Scripts.Ssar.Combat.HeroStateMachines.Animation animation, Assets.Scripts.Ssar.Combat.HeroStateMachines.Movement movement, Assets.Scripts.Ssar.Combat.HeroStateMachines.Event @event, Hero hero, BaseHeroTemplateArgs baseHeroTemplateArgs, CharacterInput ci, CharacterJump cj);

		protected Assets.Scripts.Ssar.Combat.HeroStateMachines.Animation CreateAnimationController(AbsHeroData heroData, EntityAbilities abilities, Entity entity, GameObject gObject, RoutineRunner routineRunner)
		{
			UnityEngine.Animation nativeAnimation = gObject.GetComponent<UnityEngine.Animation>();
			if (nativeAnimation == null)
			{
				nativeAnimation = gObject.AddComponent<UnityEngine.Animation>();
			}
			return new CharacterAnimation(nativeAnimation, gObject.transform, routineRunner, new Dictionary<string, float>());
		}

		private float BonusTimeScale(UnityEngine.Animation nativeAnimation, SkillConfig sc, SkeletonAnimation spineAnimation, AttackComponent ac)
		{
			return 0f;
		}

		public static float BaseTimeScale(UnityEngine.Animation nativeAnimation, SkeletonAnimation spineAnimation, string animationName)
		{
			return 0f;
		}

		protected virtual void OnBuild(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected virtual void FinishSetupBase(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected virtual void OverrideSetupFromPrefab(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected virtual void Final(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected abstract string GetGroup();

		protected abstract string GetTag();

		private void ListenMoveState(Entity entity)
		{
		}

		private CharacterObjectCaching GetCachingObject(CharacterMediatorComponent character)
		{
			return null;
		}

		private void ListenOnCastSkill(Entity entity)
		{
		}

		private void ListenOnJump(Entity entity)
		{
		}

		private void ListenOnDash(Entity entity)
		{
		}

		protected void ApplyIndividualMaterial(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected void LoadMaterial(ref Material mat, string path)
		{
		}

		protected void SetMaterial(Entity entity, Material loadedMat, bool reApplyTexture = true, bool updateWeapon = false)
		{
		}

		protected string GetIndividualMaterial(int groupId, int subId, Renderer renderer)
		{
			return null;
		}

		protected virtual string GetBaseMaterial(Renderer renderer)
		{
			return null;
		}
	}
}
