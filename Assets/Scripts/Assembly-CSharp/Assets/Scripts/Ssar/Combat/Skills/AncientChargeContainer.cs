using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class AncientChargeContainer
	{
		public Dictionary<string, AncientCharge> chargeBySkillIds;

		public void AddCharge(string skillId, int level, int usedCharge)
		{
		}

		public bool TryGetCharge(string skillId, ref AncientCharge charge)
		{
			return false;
		}
	}
}
