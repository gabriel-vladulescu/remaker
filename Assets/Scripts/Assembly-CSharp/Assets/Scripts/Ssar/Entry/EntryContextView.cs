using strange.extensions.context.impl;

namespace Assets.Scripts.Ssar.Entry
{
	public class EntryContextView : ContextView
	{
		// Real decompiled signature uses Start(), not an Awake() override
		// (unlike DungeonContextView) - preserved as-is.
		private void Start()
		{
			context = new EntryContext(this, true);
			context.Start();
		}
	}
}
