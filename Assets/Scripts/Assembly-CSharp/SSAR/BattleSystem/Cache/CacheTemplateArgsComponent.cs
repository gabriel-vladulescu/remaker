using Artemis.Interface;
using SSAR.BattleSystem.EntityTemplate;

namespace SSAR.BattleSystem.Cache
{
	public class CacheTemplateArgsComponent : IComponent
	{
		public BaseHeroTemplateArgs args;

		public CacheTemplateArgsComponent(BaseHeroTemplateArgs args)
		{
		}
	}
}
