using strange.extensions.context.impl;

namespace Assets.Scripts.Ssar.Dungeon.Context
{
	public class DungeonContextView : ContextView
	{
		protected override void Awake()
		{
			context = new DungeonContext(this, true);
			context.Start();
		}

		protected new virtual void OnDestroy()
		{
			base.OnDestroy();
		}
	}
}
