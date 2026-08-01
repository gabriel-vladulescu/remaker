using Artemis;
using Artemis.Attributes;

namespace SSAR.BattleSystem.EntityTemplate
{
	[ArtemisEntityTemplate("Boss")]
	public class BossTemplate : BaseMonsterTemplate
	{
		public new const string Name = "Boss";

		protected override void OnBuild(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected override string GetTag()
		{
			return null;
		}
	}
}
