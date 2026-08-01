using System;
using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Ssar.Combat.Effects.Pool;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Combat.Skills.Logic;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.Damage;
using SSAR.BattleSystem.System.Event.Component;
using SSAR.SkillSystem.Model;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class DefaultSkillFactory : SkillFactory
	{
		public interface FrameAdjustment
		{
			int Adjust(EventFrameConfig efc);
		}

		private class UnchangedFrameAdjustment : FrameAdjustment
		{
			public int Adjust(EventFrameConfig efc)
			{
				return 0;
			}
		}

		public class FrameWithTimeScale
		{
			private int frame;

			public FrameWithTimeScale(int frame)
			{
			}

			public int ScaleWithTime(float timeScale)
			{
				return 0;
			}
		}

		public interface FactoryMonsterConfig
		{
			List<string> ListAllSkillsBy(int groupId, int id, bool isActiveSkill = true);

			AbsHeroConfig.SkillStats FindSkillStatsById(string id);

			List<string> ListAllActiveAndPassiveSkills(int groupId, int subId);

			float ShowSkillCooldown(string skillId);
		}

		private static TriggerType[] EVENT_TRIGGER_TYPES;

		private ProjectileFactory projectileFactory;

		private ProjectileEntityFactory projectileEntityFactory;

		private EntityWorld entityWorld;

		private FactoryMonsterConfig monsterConfig;

		private SkillEventFrameConfig skillEventFrameConfig;

		private PreloadPool preloadPool;

		private MonsterSpawner monsterSpawner;

		private RoutineRunner routineRunner;

		private ResourcesLoader resourcesLoader;

		private CharacterEvent characterEvent;

		private Animation animation;

		private AttackComponent attackComponent;

		private readonly HeroConfig hc;

		private readonly AbsHeroData hd;

		private readonly Hero hero;

		private FrameAdjustment frameAdjustment;

		private UserInput ui;

		private Assets.Scripts.Core.Skills.Environment environment;

		private static List<string> folderNames;

		private const string ClassWithFolderName = "{0}.Logic.{1}.{2}";

		private const string ClassWithoutFolderName = "{0}.Logic.{1}";

		public DefaultSkillFactory(ProjectileFactory pf, ProjectileEntityFactory pef, EntityWorld ew, FactoryMonsterConfig mc, SkillEventFrameConfig sefc, PreloadPool pp, MonsterSpawner ms, RoutineRunner rr, ResourcesLoader rl, EffectPool ep, CharacterEvent ce, Animation a, AttackComponent ac, HeroConfig hc, AbsHeroData hd, Hero hero, UserInput ui, FrameAdjustment fa = null)
		{
		}

		public override Skill Create(string skillId)
		{
			return null;
		}

		protected virtual float BonusTimeScale(SkillConfig skillConfig)
		{
			return 0f;
		}

		private static void ConstructDamageEventTriggers(EventFrameConfig efc, Skill s, Dependencies d, EventFrame eventFrame)
		{
		}

		private static void ConstructDamageEventTriggers(EventFrameConfig efc, Skill s, Dependencies d, EventFrame eventFrame, List<ModifierConfig> modifierConfigs)
		{
		}

		public List<ModifierConfig> FindAllModifierActionConfigOf(List<ModifierConfig> modifierConfigs, TriggerType triggerType, ModifierType modifierType)
		{
			return null;
		}

		private static void ConstructEventTriggers(SkillConfig skillConfig, Skill s, Dependencies d)
		{
		}

		private static void PostOnDeathByAttacker(Character attacker, Character defender, Skill s, Dependencies d, Action<Character, Character> onEntityDeathByAttacker)
		{
		}

		protected virtual float AdjustScalePower(SkillConfigId sci, float scalePower)
		{
			return 0f;
		}

		protected virtual ModifierStatsAdjustment ConstructModifierStatsAdjustment(SkillConfigId skillConfigId)
		{
			return null;
		}

		protected virtual float AdjustSkillPower(SkillConfigId sci, float origin)
		{
			return 0f;
		}

		protected virtual AdvancedSkillStats GetSkillStats(string skillId)
		{
			return null;
		}

		protected virtual SkillConfig FindSkillConfig(string skillId)
		{
			return null;
		}

		private bool IsHeroDashSkill(SkillConfig sc)
		{
			return false;
		}

		private string ConstructSkillClassFullName(string skillClassName)
		{
			return null;
		}

		protected int ExtractGroupIdFrom(string skillId)
		{
			return 0;
		}

		protected int ExtractSubIdFrom(string skillId)
		{
			return 0;
		}

		protected int ExtractIdFrom(string skillId)
		{
			return 0;
		}

		public override EventFrame CreateDamageFrame(EventFrameConfig efc, float scaleTime, int waveOrder, float waveInterval)
		{
			return null;
		}

		public override EventFrame CreateSpawnMonsterFrame(EventFrameConfig efc, float frame)
		{
			return null;
		}

		private ProjectileTrajectoryParams CreateProjectileTrajectoryParams(List<ProjectileTrajectoryConfig> trajectoryConfigs)
		{
			return null;
		}
	}
}
