using System.Collections.Generic;
using SSAR.BattleSystem.Damage;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class SkillData
	{
		private float scalePower;

		private float skillPower;

		private DamageType damageType;

		private SkillConfig skillConfig;

		private bool isActiveSkill;

		private Dictionary<SkillExtraStatType, double> extraStats;

		public float ScalePower => 0f;

		public float SkillPower => 0f;

		public DamageType DamageType => default(DamageType);

		public SkillConfig SkillConfig => null;

		public bool IsActiveSkill => false;

		public SkillData(float scalePower, float skillPower, DamageType damageType, bool isActiveSkill, SkillConfig skillConfig, Dictionary<SkillExtraStatType, double> extraStats)
		{
		}

		public float GetExtraStat(SkillExtraStatType extraStatType)
		{
			return 0f;
		}
	}
}
