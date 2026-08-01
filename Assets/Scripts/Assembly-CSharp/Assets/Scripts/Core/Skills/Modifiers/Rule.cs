namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class Rule
	{
		public bool CheckKnockbackApplicable(float casterKnockbackLevel, float targetKnockbackResistLevel)
		{
			return false;
		}

		public bool CheckKnockdownApplicable(float casterKnockdownLevel, float targetKnockbackResistLevel)
		{
			return false;
		}
	}
}
