using System;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class WatchVodRetainResourcesCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public Action Action { get; set; }

		public override void Execute()
		{
		}

		private void RetainSuccess()
		{
		}
	}
}
