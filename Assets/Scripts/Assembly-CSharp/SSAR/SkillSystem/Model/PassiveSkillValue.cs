using Assets.Scripts.Config.Stats;
using Scripts.Config;

namespace SSAR.SkillSystem.Model
{
	public class PassiveSkillValue
	{
		private SkillConfigId skillConfigId;

		private HeroConfig heroConfig;

		private SkillEquippedData characterSkillData;

		private HeroData heroData;

		private float value;

		public PassiveSkillValue(SkillConfigId skillConfigId, HeroConfig heroConfig, SkillEquippedData characterSkillData, HeroData heroData)
		{
		}

		private void ProcessValue()
		{
		}

		public float Value()
		{
			return 0f;
		}
	}
}
