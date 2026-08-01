using SSAR.SkillSystem.Model;

namespace Assets.Scripts.Config.Stats
{
	public class WeaponActiveSkillData
	{
		private SkillConfigId skillConfigId;

		private float power;

		private float cooldownReduction;

		public SkillConfigId SkillConfigId => null;

		public float Power => 0f;

		public float CooldownReduction => 0f;

		public WeaponActiveSkillData(SkillConfigId skillConfigId, float power, float cooldownReduction)
		{
		}
	}
}
