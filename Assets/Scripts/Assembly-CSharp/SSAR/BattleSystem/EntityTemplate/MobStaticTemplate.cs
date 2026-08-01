using Artemis;
using Artemis.Attributes;

namespace SSAR.BattleSystem.EntityTemplate
{
	[ArtemisEntityTemplate("mob_static")]
	public class MobStaticTemplate : BaseMonsterTemplate
	{
		public new const string Name = "mob_static";

		protected override void OnBuild(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}

		protected override void Final(Entity entity, BaseHeroTemplateArgs baseHeroTemplateArgs)
		{
		}
	}
}
