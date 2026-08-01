using Artemis;
using SSAR.BattleSystem.EntityTemplate;

namespace Assets.Scripts.Ssar.BattleSystem.EntityTemplate
{
	public class ArenaEnemyTemplate : MainCharacterTemplate
	{
		public new const string Name = "ArenaEnemy";

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

		protected override MainCharacterData GetMainCharacterData()
		{
			return null;
		}
	}
}
