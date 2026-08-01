using Artemis;
using Assets.Scripts.Ssar.Dungeon.Command;
using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.Dungeon.View;
using UnityEngine;
using strange.extensions.context.api;

namespace Assets.Scripts.Ssar.Dungeon.Context
{
	public class DungeonContext : DungeonSignalContext
	{
		public DungeonContext(MonoBehaviour view, bool autoMapping)
			: base(view, autoMapping)
		{
		}

		// Simplified boot wiring: only what InitDungeonSystemCmd (see that
		// file for the full rationale) and UserButtonInputLayoutMediator
		// actually need. The original game's mapBindings() presumably also
		// registers monster/achievement/quest/config managers here; those are
		// out of scope for movement/input testing and left unbound.
		//
		// This game's commandBinder is a SignalCommandBinder (bound in
		// MVCSContext.addCoreComponents()), which unconditionally casts its
		// binding key to IBaseSignal in ResolveBinding/Unbind - binding a
		// plain event value like ContextEvent.START throws InvalidCastException
		// at runtime. Signals only, so OnDungeonStartSignal is the trigger
		// instead, dispatched from Launch() below.
		protected override void mapBindings()
		{
			commandBinder.Bind<OnDungeonStartSignal>().To<InitDungeonSystemCmd>();

			// OnSpawnMainCharacterSignal is dispatched/listened-to directly
			// (InitDungeonSystemCmd.Dispatch -> UserButtonInputLayoutMediator
			// .AddListener) rather than routed through commandBinder, so it
			// needs its own injection binding - commandBinder.Bind<T>() is
			// what implicitly creates that binding for signals used as
			// command triggers, and nothing binds this one as a trigger.
			injectionBinder.Bind<OnSpawnMainCharacterSignal>().ToSingleton();

			mediationBinder.Bind<UserButtonInputLayout>().To<UserButtonInputLayoutMediator>();
		}

		public override void Launch()
		{
			base.Launch();
			OnDungeonStartSignal startSignal = injectionBinder.GetInstance<OnDungeonStartSignal>() as OnDungeonStartSignal;
			startSignal.Dispatch();
		}

		public override IContext RemoveContext(IContext context)
		{
			return base.RemoveContext(context);
		}
	}
}
