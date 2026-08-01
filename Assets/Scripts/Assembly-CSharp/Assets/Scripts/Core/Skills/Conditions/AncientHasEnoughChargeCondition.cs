using Artemis;

namespace Assets.Scripts.Core.Skills.Conditions
{
	public class AncientHasEnoughChargeCondition : Condition
	{
		private string skillId;

		private Entity entity;

		public AncientHasEnoughChargeCondition(string skillId, Entity entity)
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
