using System;
using Scripts.Config;

namespace Assets.Scripts.Ssar.Command
{
	public class ShowAskForSavePopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public Action Action { get; set; }

		[Inject]
		public ConfigManager configManager { get; set; }

		public override void Execute()
		{
		}

		protected override string GetAssetPath()
		{
			return null;
		}

		protected override string GetInjectName()
		{
			return null;
		}

		protected override PopupCamera GetCamera()
		{
			return default(PopupCamera);
		}
	}
}
