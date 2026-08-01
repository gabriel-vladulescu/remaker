using System.Collections.Generic;
using Artemis.Interface;
using SSAR.BattleSystem.CharacterStatus;
using Scripts.Config;
using Scripts.Config.Stats;

namespace SSAR.BattleSystem.Damage
{
	public class HealthComponent : IComponent
	{
		public AutoRecoveryHp AutoRecoveryHp;

		private float _maxHealthDiffProp;

		private float _defenceDiffProp;

		private float _magicResistDiffProp;

		private float _damageReductionDiff;

		private float _damageAmplificationDiff;

		private float _magicDamageBlockDiff;

		private float _dodgeChanceDiff;

		private EntityAbilities StatConfig;

		private float _curHealth;

		public Stack<DamageInfo> damageList;

		private StatsCap sc;

		private bool beatable;

		private bool keepEntityAfterDie;

		private float suicideCountdown;

		public float originalMaxHealth { get; set; }

		public float originalDef { get; set; }

		public float originalMagicResist { get; set; }

		public float originalDamageReduction { get; set; }

		public float originalDamageBlockPerAttack { get; set; }

		public float originalMagicDamageBarrier { get; set; }

		public float originalDodgeChance { get; set; }

		public float MaxHealth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MaxHpForDisplay => 0f;

		public float curHealth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float curDef
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float curMagicResist
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float curDamageReduction => 0f;

		public float curDamageBlockPerAttack => 0f;

		public float curMagicDamageBarrier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float dodgeChance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public DeathReason DeathReason { get; protected set; }

		public float blockChance { get; set; }

		public float bossDamageReduction { get; set; }

		public float SuicideCountdown => 0f;

		public string LastAttacker { get; set; }

		public HealthComponent(AbsHeroData heroData, EntityAbilities abilities, StatsCap statsCap)
		{
		}

		public void ReceiveDamage(DamageInfo damageInfo)
		{
		}

		public bool IsAlive()
		{
			return false;
		}

		public void ChangeToDeath(DeathReason deathReason)
		{
		}

		public bool IsBeatable()
		{
			return false;
		}

		public void SetBeatable(bool beatable)
		{
		}

		public bool IsKeepEntityAfterDie()
		{
			return false;
		}

		public void SetKeepEntityAfterDie(bool keep)
		{
		}

		public void SetSuicideCountdown(float time)
		{
		}

		public bool IsSuicideable()
		{
			return false;
		}

		public void UpdateSuicideCountdown(float delta)
		{
		}

		public void AddDamageReduction(float value)
		{
		}
	}
}
