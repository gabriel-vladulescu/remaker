using Assets.Scripts.Core.Skills.Modifiers;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic
{
	public class DefaultPrayInfo : PrayModifier.PrayInfo
	{
		private readonly float _duration;

		private readonly float _attackBonus;

		private readonly float _defenseBonus;

		private readonly float _hpBonus;

		public DefaultPrayInfo(float duration, float attackBonus, float defenseBonus, float hpBonus)
		{
		}

		public float Duration()
		{
			return 0f;
		}

		public float AttackBonus()
		{
			return 0f;
		}

		public float DefenseBonus()
		{
			return 0f;
		}

		public float HpBonus()
		{
			return 0f;
		}
	}
}
