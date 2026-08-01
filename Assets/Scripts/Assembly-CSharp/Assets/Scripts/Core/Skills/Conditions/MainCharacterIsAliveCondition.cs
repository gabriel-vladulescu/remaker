using SSAR.BattleSystem.Damage;

namespace Assets.Scripts.Core.Skills.Conditions
{
	public class MainCharacterIsAliveCondition : Condition
	{
		private HealthComponent mainHealthComponent;

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
