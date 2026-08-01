using Artemis;
using Artemis.Attributes;
using SSAR.BattleSystem.EntityTemplate;

namespace Assets.Scripts.Ssar.BattleSystem.EntityTemplate
{
	[ArtemisEntityTemplate("RaidCompanion")]
	public class RaidCompanionTemplate : MainCharacterTemplate
	{
		public new const string Name = "RaidCompanion";

		private string materialPath;

		protected override void OnBuild(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		private void SetupMaterial(Entity entity)
		{
		}

		protected override string GetTag()
		{
			return null;
		}

		protected override string GetAITab()
		{
			return null;
		}

		protected override bool EnableAI()
		{
			return false;
		}

		protected override MainCharacterData GetMainCharacterData()
		{
			return null;
		}
	}
}
