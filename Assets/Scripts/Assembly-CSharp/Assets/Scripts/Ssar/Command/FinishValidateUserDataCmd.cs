using Scripts.Config;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Command
{
	public class FinishValidateUserDataCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public UserData UserData { get; set; }

		public override void Execute()
		{
		}

		private void InitEquipmentGenerationConfig(ConfigManager configManager)
		{
		}

		private void InitDropLogic()
		{
		}

		private void ValidateShopVendor()
		{
		}

		private void SaveVersionPlayed()
		{
		}
	}
}
