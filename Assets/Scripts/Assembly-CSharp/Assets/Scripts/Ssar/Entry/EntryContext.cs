using UnityEngine;
using strange.extensions.context.api;

namespace Assets.Scripts.Ssar.Entry
{
	public class EntryContext : SignalContext
	{
		public EntryContext(MonoBehaviour view, bool autoMapping)
		{
		}

		protected override void mapBindings()
		{
		}

		private void InitMetric()
		{
		}

		public override IContext RemoveContext(IContext context)
		{
			return null;
		}
	}
}
