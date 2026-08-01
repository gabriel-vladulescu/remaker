using Ssar.Craft.Model;
using strange.extensions.command.impl;

namespace Ssar.Craft.Command
{
	public class SellMaterialCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public CraftingMaterial Material { get; set; }

		[Inject]
		public int quantity { get; set; }

		[Inject]
		public OnSellMaterialSuccessSignal OnSellMaterialSuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
