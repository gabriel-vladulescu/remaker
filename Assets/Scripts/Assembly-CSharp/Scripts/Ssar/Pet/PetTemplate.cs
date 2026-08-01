using System.Collections.Generic;
using Artemis;
using Artemis.Attributes;
using Assets.Scripts.Ssar.Combat.Skills;
using SSAR.BattleSystem.EntityTemplate;
using SSAR.BattleSystem.System.Input.Model;
using Scripts.Config;

namespace Scripts.Ssar.Pet
{
	[ArtemisEntityTemplate("pet")]
	public class PetTemplate : BaseMonsterTemplate
	{
		private class PetConfigToFactoryMonsterConfig : DefaultSkillFactory.FactoryMonsterConfig
		{
			private PetConfig petConfig;

			public PetConfigToFactoryMonsterConfig(PetConfig petConfig)
			{
			}

			public List<string> ListAllSkillsBy(int groupId, int id, bool isActiveSkill = true)
			{
				return null;
			}

			public AbsHeroConfig.SkillStats FindSkillStatsById(string id)
			{
				return null;
			}

			public List<string> ListAllActiveAndPassiveSkills(int groupId, int subId)
			{
				return null;
			}

			public float ShowSkillCooldown(string skillId)
			{
				return 0f;
			}
		}

		public new const string Name = "pet";

		private string materialPath;

		protected override void OnBuild(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		private void SetupMaterial(Entity entity)
		{
		}

		protected override string GetGroup()
		{
			return null;
		}

		protected override DefaultSkillFactory.FactoryMonsterConfig GetFactoryMonsterConfig(ConfigManager configManager)
		{
			return null;
		}

		protected override CharacterInput GetCharacterInput(ConfigManager configManager, int groupId, int subId)
		{
			return null;
		}

		protected override bool CountCooldown()
		{
			return false;
		}
	}
}
