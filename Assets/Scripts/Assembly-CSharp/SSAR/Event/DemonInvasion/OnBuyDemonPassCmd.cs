using Assets.Scripts.Ssar.Iap;
using strange.extensions.command.impl;

namespace Ssar.Event.DemonInvasion
{
	public class OnBuyDemonPassCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public PaymentService PaymentService { get; set; }

		public override void Execute()
		{
		}
	}
}
