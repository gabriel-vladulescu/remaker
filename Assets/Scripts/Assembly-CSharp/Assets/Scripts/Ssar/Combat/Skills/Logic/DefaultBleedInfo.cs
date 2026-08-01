using Assets.Scripts.Core.Skills.Modifiers;
using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultBleedInfo : BleedModifier.Info
	{
		private float successRate;

		private float duration;

		private float interval;

		private float damageScale;

		private DamageType damageType;

		public DefaultBleedInfo(float successRate, float duration, float interval, float damageScale, DamageType damageType)
		{
		}

		public float SuccessRate()
		{
			return 0f;
		}

		public float Duration()
		{
			return 0f;
		}

		public float Interval()
		{
			return 0f;
		}

		public float DamageScale()
		{
			return 0f;
		}

		public DamageType ShowDamageType()
		{
			return default(DamageType);
		}
	}
}
