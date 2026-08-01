using System.Collections.Generic;
using Artemis;
using Assets.Scripts.Config.Stats;
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
	internal class HeroSkillFactory : DefaultSkillFactory
	{
		private ProjectileFactory projectileFactory;

		private ProjectileEntityFactory projectileEntityFactory;

		private EntityWorld entityWorld;

		private FactoryMonsterConfig monsterConfig;

		private SkillEventFrameConfig skillEventFrameConfig;

		private PreloadPool preloadPool;

		private MonsterSpawner monsterSpawner;

		private HeroConfig heroConfig;

		private SkillEquippedData characterSkillData;

		private HeroData heroData;

		private AttackComponent attackComponent;

		private JsonEquipmentDropConfig jedc;

		private AncientEquipmentConfig ancientConfig;

		private List<string> combos;

		public HeroSkillFactory(ProjectileFactory pf, ProjectileEntityFactory pef, EntityWorld ew, FactoryMonsterConfig mc, SkillEventFrameConfig sefc, PreloadPool pp, MonsterSpawner ms, HeroConfig hc, RoutineRunner rr, SkillEquippedData csd, HeroData hd, ResourcesLoader rl, EffectPool ep, CharacterEvent ce, Animation a, AttackComponent ac, JsonEquipmentDropConfig jedc, AncientEquipmentConfig ancientConfig, Hero h, UserInput ui, FrameAdjustment fa = null)
			: base(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null)
		{
		}

		protected override AdvancedSkillStats GetSkillStats(string skillId)
		{
			return null;
		}

		protected override SkillConfig FindSkillConfig(string skillId)
		{
			return null;
		}

		protected override float AdjustSkillPower(SkillConfigId sci, float origin)
		{
			return 0f;
		}

		protected override float BonusTimeScale(SkillConfig skillConfig)
		{
			return 0f;
		}

		protected override float AdjustScalePower(SkillConfigId sci, float origin)
		{
			return 0f;
		}

		protected override ModifierStatsAdjustment ConstructModifierStatsAdjustment(SkillConfigId skillConfigId)
		{
			return null;
		}
	}
}
