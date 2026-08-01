using System.Collections.Generic;

namespace Assets.Scripts.Core.Skills.Cooldowns
{
	public class CooldownsCollection
	{
		private Dictionary<string, Cooldown> cooldownBySkillId;

		public void AddCooldown(string skillId, Cooldown cd)
		{
		}

		public bool TryGetCooldown(string skillId, ref Cooldown cd)
		{
			return false;
		}
	}
}
