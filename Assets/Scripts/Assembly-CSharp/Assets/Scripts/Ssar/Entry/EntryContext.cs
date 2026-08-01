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

		// No Entry-scoped signals/commands identified yet - this context
		// exists mainly so EntryContextView's StrangeIoC boot sequence runs
		// without throwing, alongside GameInitController's own
		// (non-StrangeIoC) boot flow which does the actual scene work.
		protected override void mapBindings()
		{
		}

		public override IContext RemoveContext(IContext context)
		{
			return base.RemoveContext(context);
		}
	}
}
