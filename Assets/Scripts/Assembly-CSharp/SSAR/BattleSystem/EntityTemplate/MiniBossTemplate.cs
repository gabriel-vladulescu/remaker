using Artemis;
using Artemis.Attributes;

namespace SSAR.BattleSystem.EntityTemplate
{
	[ArtemisEntityTemplate("miniBoss")]
	public class MiniBossTemplate : BaseMonsterTemplate
	{
		public new const string Name = "miniBoss";

		protected override void OnBuild(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected override string GetTag()
		{
			return null;
		}
	}
}
