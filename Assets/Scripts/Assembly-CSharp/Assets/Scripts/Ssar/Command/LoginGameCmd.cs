using Assets.Scripts.Ssar.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class LoginGameCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public LoginMethod LoginMethod { get; set; }

		[Inject]
		public LoginGameErrorSignal LoginGameErrorSignal { get; set; }

		[Inject]
		public LoginGameSuccessSignal LoginGameSuccessSignal { get; set; }

		public override void Execute()
		{
		}

		private void DoLogin()
		{
		}

		private void Login()
		{
		}

		private void LoadLocal()
		{
		}
	}
}
