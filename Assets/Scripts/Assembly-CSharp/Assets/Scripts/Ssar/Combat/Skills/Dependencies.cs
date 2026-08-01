using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Ssar.Combat.HeroStateMachines;
using Assets.Scripts.Ssar.Combat.Skills.Logic;
using Assets.Scripts.Ssar.Common.System.RoutineRunner;
using SSAR.BattleSystem.System.Event.Component;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class Dependencies
	{
		private SkillData skillData;

		private ProjectileFactory projectileFactory;

		private ProjectileEntityFactory projectileEntityFactory;

		private EntityWorld entityWorld;

		private MonsterSpawner monsterSpawner;

		private Environment environment;

		private BuffFactory buffFactory;

		private RoutineRunner routineRunner;

		private ModifierStatsAdjustment modifierStatsAdjustment;

		private OnHitTargetListener onHitTargetListener;

		private CharacterEvent characterEvent;

		private HeroConfig heroConfig;

		private AbsHeroData heroData;

		private Hero hero;

		public SkillData SkillData => null;

		public ProjectileFactory ProjectileFactory => null;

		public ProjectileEntityFactory ProjectileEntityFactory => null;

		public EntityWorld EntityWorld => null;

		public MonsterSpawner MonsterSpawner => null;

		public Environment Environment => null;

		public BuffFactory BuffFactory => null;

		public RoutineRunner RoutineRunner => null;

		public ModifierStatsAdjustment ModifierStatsAdjustment => null;

		public OnHitTargetListener OnHitTargetListener => null;

		public CharacterEvent CharacterEvent => null;

		public HeroConfig HeroConfig => null;

		public AbsHeroData HeroData => null;

		public Hero Hero => null;

		public Dependencies(SkillData skillData, ProjectileFactory projectileFactory, ProjectileEntityFactory projectileEntityFactory, EntityWorld entityWorld, MonsterSpawner monsterSpawner, Environment environment, BuffFactory buffFactory, RoutineRunner routineRunner, ModifierStatsAdjustment modifierStatsAdjustment, CharacterEvent characterEvent, HeroConfig heroConfig, AbsHeroData heroData, Hero hero, OnHitTargetListener onHitTargetListener = null)
		{
		}
	}
}
