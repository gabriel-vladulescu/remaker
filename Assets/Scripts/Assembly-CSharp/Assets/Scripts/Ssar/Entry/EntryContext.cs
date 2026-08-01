using UnityEngine;
using strange.extensions.context.api;

namespace Assets.Scripts.Ssar.Entry
{
	public class EntryContext : SignalContext
	{
		public EntryContext(MonoBehaviour view, bool autoMapping)
			: base(view, autoMapping)
		{
		}

		// EntryContext is created once in EntryScene and, because
		// GameInitController.Awake() marks itself (and the GameInit.prefab
		// hierarchy EntryContextView lives in) DontDestroyOnLoad, it
		// persists as StrangeIoC's Context.firstContext for the entire app
		// lifetime. That's what makes View.Start()/OnEnable() auto-registration
		// (see UserButtonInputLayout's comment for the same pattern) work for
		// views instantiated in later scenes like MainScenePopup - they all
		// register against this one persistent context.
		protected override void mapBindings()
		{
			mediationBinder.Bind<MainScenePopup>().To<MainScenePopupMediator>();
		}

		public override IContext RemoveContext(IContext context)
		{
			return base.RemoveContext(context);
		}
	}
}
