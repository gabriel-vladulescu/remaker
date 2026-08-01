using System.Collections.Generic;
using Artemis;
using Artemis.Attributes;
using Assets.Scripts.Core.Skills.Cooldowns;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.AI;
using SSAR.BattleSystem.Movement;
using SSAR.BattleSystem.System.Input.Model;
using Scripts.Config;
using UnityEngine;

namespace SSAR.BattleSystem.EntityTemplate
{
	[ArtemisEntityTemplate("baseMonster")]
	public abstract class BaseMonsterTemplate : BaseEntityTemplate
	{
		private class MonsterRenderer : DefaultSkillCharacter.Renderer
		{
			private Renderer[] renderers;

			private ParticleSystem[] particleSystems;

			public MonsterRenderer(GameObject gameObject)
			{
			}

			public void TurnOn()
			{
			}

			public void TurnOff()
			{
			}

			public void TurnOnParticles()
			{
			}

			public void TurnOffParticles()
			{
			}
		}

		public class MonsterConfigToSkillFactoryMonsterConfig : DefaultSkillFactory.FactoryMonsterConfig
		{
			private MonsterConfig monsterConfig;

			public MonsterConfigToSkillFactoryMonsterConfig(MonsterConfig monsterConfig)
			{
			}

			public List<string> ListAllSkillsBy(int groupId, int id, bool isActiveSkill = true)
			{
				return null;
			}

			public AbsHeroConfig.SkillStats FindSkillStatsById(string id)
			{
				return null;
			}

			public List<string> ListAllActiveAndPassiveSkills(int groupId, int subId)
			{
				return null;
			}

			public float ShowSkillCooldown(string skillId)
			{
				return 0f;
			}
		}

		public new const string Name = "baseMonster";

		protected override void OnBuild(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		public static GameObject InstantiateGameObjectFromPrefab(GameObject prefab)
		{
			return null;
		}

		protected override void OverrideSetupFromPrefab(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected override string GetGroup()
		{
			return null;
		}

		protected override string GetTag()
		{
			return null;
		}

		private NewMonsterAIComponent GetNewMonsterAiComponent(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs, string mobType)
		{
			return null;
		}

		protected override HeroStateMachine GetHeroStateMachine(GameObject monsterGameObject, Entity entity, UserInput userInput, Assets.Scripts.Ssar.Combat.HeroStateMachines.Animation animation, Assets.Scripts.Ssar.Combat.HeroStateMachines.Movement movement, Assets.Scripts.Ssar.Combat.HeroStateMachines.Event @event, Hero hero, BaseHeroTemplateArgs baseHeroTemplateArgs, CharacterInput ci, CharacterJump cj)
		{
			return null;
		}

		protected virtual bool CountCooldown()
		{
			return false;
		}

		protected virtual DefaultSkillFactory.FactoryMonsterConfig GetFactoryMonsterConfig(ConfigManager configManager)
		{
			return null;
		}

		public virtual CooldownsCollection GetCooldownsCollection()
		{
			return null;
		}
	}
}
