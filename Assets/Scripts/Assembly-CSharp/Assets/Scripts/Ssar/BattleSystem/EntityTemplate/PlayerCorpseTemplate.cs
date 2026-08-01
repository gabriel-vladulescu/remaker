using Artemis;
using Artemis.Attributes;
using SSAR.BattleSystem.EntityTemplate;

namespace Assets.Scripts.Ssar.BattleSystem.EntityTemplate
{
	[ArtemisEntityTemplate("PlayerCorpse")]
	public class PlayerCorpseTemplate : MainCharacterTemplate
	{
		public new const string Name = "PlayerCorpse";

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
	}
}
