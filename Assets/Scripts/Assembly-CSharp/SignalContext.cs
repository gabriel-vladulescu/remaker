using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.context.impl;

// Thin pass-through over MVCSContext, same role as
// Assets.Scripts.Ssar.Dungeon.Context.DungeonSignalContext (see that file's
// comment for why this layer exists). Root-namespace shared base used by
// EntryContext.
public class SignalContext : MVCSContext
{
	public SignalContext()
		: base()
	{
	}

	public SignalContext(MonoBehaviour view)
		: base(view)
	{
	}

	public SignalContext(MonoBehaviour view, ContextStartupFlags flags)
		: base(view, flags)
	{
	}

	public SignalContext(MonoBehaviour view, bool autoMapping)
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
