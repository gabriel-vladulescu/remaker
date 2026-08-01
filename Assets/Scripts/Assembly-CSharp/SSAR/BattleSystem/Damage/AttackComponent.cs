using Artemis.Interface;
using Scripts.Config;
using Scripts.Config.Stats;

namespace SSAR.BattleSystem.Damage
{
	public class AttackComponent : IComponent
	{
		public float originalCritChance;

		public float originalAttackDamage;

		public float originalCritDamageMul;

		public float originalSkillDamage;

		public float originalHpPerHit;

		public float originalDamageAgainstBoss;

		public float originalAttackSpeed;

		public float originalCooldownReduction;

		public float originalLifeSteal;

		public float originalMissChance;

		public float originalHpPercentPerKill;

		public float originalBonusAttackSpeed;

		public float originalSkillCritChance;

		public float originalSkillCritDmg;

		public float originalPvpDamageBonus;

		private StatsCap sc;

		private float _critRateDiff;

		private float _critDamageMulDiff;

		private float _skillCritRateDiff;

		private float _skillCritDamageMulDiff;

		private float _attackDamageDiffProp;

		private float _skillDamageDiff;

		private float _hpPerHitDiff;

		public float curCritChance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float curSkillCritChance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float curAttackDamage
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float curCritDamageMul
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float curSkillCritDamageMul
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CurSkillDamage
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CurHpPerHit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CurDamageAgainstBoss
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CurAttackSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float BonusAttackSpeed => 0f;

		public float CurCooldownReduction
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CurLifeSteal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CurMissChance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CurPvpDamageBonus { get; set; }

		public float CurHpPercentPerKill
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AttackComponent(AbsHeroData heroData, EntityAbilities abilities, StatsCap statsCap)
		{
		}
	}
}
