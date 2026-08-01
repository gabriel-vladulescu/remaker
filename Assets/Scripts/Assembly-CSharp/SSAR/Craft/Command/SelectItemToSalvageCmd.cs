using Ssar.Craft.Model;
using strange.extensions.command.impl;

namespace Ssar.Craft.Command
{
	public class SelectItemToSalvageCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public SelectItemToSalvageParameter Parameter { get; set; }

		[Inject]
		public OnSelectSalvageItemSignal OnSelectSalvageItemSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
