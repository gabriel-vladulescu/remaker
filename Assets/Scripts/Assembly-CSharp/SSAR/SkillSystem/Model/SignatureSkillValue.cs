using Assets.Scripts.Config.Stats;
using Scripts.Config;

namespace SSAR.SkillSystem.Model
{
	public class SignatureSkillValue
	{
		private SkillConfigId skillConfigId;

		private HeroConfig heroConfig;

		private SkillEquippedData characterSkillData;

		private HeroData heroData;

		private float value;

		public SignatureSkillValue(SkillConfigId skillConfigId, HeroConfig heroConfig, SkillEquippedData characterSkillData, HeroData heroData)
		{
		}

		private void ProcessValues()
		{
		}

		public float Value()
		{
			return 0f;
		}
	}
}
