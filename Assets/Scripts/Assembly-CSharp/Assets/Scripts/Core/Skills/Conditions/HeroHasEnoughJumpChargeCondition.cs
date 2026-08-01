using Assets.Scripts.Ssar.Combat.HeroStateMachines;

namespace Assets.Scripts.Core.Skills.Conditions
{
	public class HeroHasEnoughJumpChargeCondition : Condition
	{
		private Hero hero;

		public HeroHasEnoughJumpChargeCondition(Hero hero)
		{
		}

		public bool IsMeet()
		{
			return false;
		}

		public void Update(float dt)
		{
		}

		public string Reason()
		{
			return null;
		}
	}
}
