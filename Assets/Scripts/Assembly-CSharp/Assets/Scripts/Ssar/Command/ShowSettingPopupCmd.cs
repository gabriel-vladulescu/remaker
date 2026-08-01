using System;

namespace Assets.Scripts.Ssar.Command
{
	public class ShowSettingPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public Action onhide { get; set; }

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
