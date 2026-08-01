using System.Collections.Generic;

namespace SSAR.Cooldown.System
{
	public class SkillCooldownManager
	{
		private class CooldownData
		{
			public double originalCooldown;

			public double currentCooldown;

			public CooldownData(double cooldown)
			{
			}
		}

		private Dictionary<int, CooldownData> cooldowns;

		public void SetupCooldown(int id, double cooldown)
		{
		}

		public float GetCooldown(int id)
		{
			return 0f;
		}

		public void ResetCooldown(int id)
		{
		}

		public void Update(float deltaTime)
		{
		}
	}
}
