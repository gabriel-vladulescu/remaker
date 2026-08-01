using System;
using Ssar.Craft.Model;

namespace Ssar.Craft.Command
{
	public class ReceiveCraftItemParams
	{
		public CraftItemProgress Progress;

		public Action callback;

		public ReceiveCraftItemParams(CraftItemProgress progress, Action callback)
		{
		}

		public ReceiveCraftItemParams(CraftItemProgress progress)
		{
		}
	}
}
