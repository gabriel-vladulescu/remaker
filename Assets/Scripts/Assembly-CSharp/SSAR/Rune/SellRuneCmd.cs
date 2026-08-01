using Ssar.Rune.Model;
using strange.extensions.command.impl;

namespace Ssar.Rune
{
	public class SellRuneCmd : Command
	{
		[Inject]
		public Ssar.Rune.Model.Rune Rune { get; set; }

		[Inject]
		public int quantity { get; set; }

		[Inject]
		public OnSellRuneSuccessSignal OnSellRuneSuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
