using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using strange.extensions.command.api;
using strange.extensions.injector.api;
using strange.extensions.mediation.api;

namespace SSAR.Entry.Model
{
	public class DungeonBindingConfig : AbsBindingConfig
	{
		private IBattleModeLogic battleModeLogic;

		public DungeonBindingConfig(IBattleModeLogic battleModeLogic)
		{
		}

		public override void MapBindings(ICrossContextInjectionBinder injectionBinder, ICommandBinder commandBinder, IMediationBinder mediationBinder)
		{
		}
	}
}
