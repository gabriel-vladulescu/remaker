using SSAR.Entry.Model;
using strange.extensions.command.api;
using strange.extensions.injector.api;
using strange.extensions.mediation.api;

namespace SSAR.SkillSystem.Model
{
	public class SkillBindingConfig : AbsBindingConfig
	{
		public override void MapBindings(ICrossContextInjectionBinder injectionBinder, ICommandBinder commandBinder, IMediationBinder mediationBinder)
		{
		}
	}
}
