using SSAR.Entry.Model;
using strange.extensions.command.api;
using strange.extensions.injector.api;
using strange.extensions.mediation.api;

namespace Ssar.DailyReward.Binding
{
	public class DailyRewardBindingConfig : AbsBindingConfig
	{
		private AbsBindingConfig absBindingConfigImplementation;

		public override void MapBindings(ICrossContextInjectionBinder injectionBinder, ICommandBinder commandBinder, IMediationBinder mediationBinder)
		{
		}
	}
}
