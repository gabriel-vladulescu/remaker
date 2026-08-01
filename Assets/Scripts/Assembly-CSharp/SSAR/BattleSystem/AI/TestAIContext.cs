using UnityEngine;
using strange.extensions.context.api;

namespace SSAR.BattleSystem.AI
{
	public class TestAIContext : TestAISignalContext
	{
		public TestAIContext(MonoBehaviour view, bool autoMapping)
		{
		}

		protected override void mapBindings()
		{
		}

		public override IContext RemoveContext(IContext context)
		{
			return null;
		}
	}
}
