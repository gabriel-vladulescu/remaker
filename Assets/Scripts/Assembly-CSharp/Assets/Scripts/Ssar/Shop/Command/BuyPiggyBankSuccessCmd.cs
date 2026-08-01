using Assets.Scripts.Ssar.Signal;
using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Shop.Command
{
	public class BuyPiggyBankSuccessCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public PiggyBankItem bought { get; set; }

		[Inject]
		public OnBuyPiggyBankSuccessSignal OnBuyPiggyBankSuccessSignal { get; set; }

		public override void Execute()
		{
		}
	}
}
