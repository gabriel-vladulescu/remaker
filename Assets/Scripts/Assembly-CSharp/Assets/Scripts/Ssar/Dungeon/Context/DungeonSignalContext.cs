using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.context.impl;

namespace Assets.Scripts.Ssar.Dungeon.Context
{
	// Thin pass-through over MVCSContext. mapBindings() is left for
	// DungeonContext (the only subclass) to fill in; this layer exists purely
	// to match the original class hierarchy found in the decompiled metadata.
	public class DungeonSignalContext : MVCSContext
	{
		public DungeonSignalContext()
			: base()
		{
		}

		public DungeonSignalContext(MonoBehaviour view)
			: base(view)
		{
		}

		public DungeonSignalContext(MonoBehaviour view, ContextStartupFlags flags)
			: base(view, flags)
		{
		}

		public DungeonSignalContext(MonoBehaviour view, bool autoMapping)
			: base(view, autoMapping)
		{
		}

		protected override void mapBindings()
		{
		}

		protected override void addCoreComponents()
		{
			base.addCoreComponents();
		}

		public override void Launch()
		{
			base.Launch();
		}
	}
}
