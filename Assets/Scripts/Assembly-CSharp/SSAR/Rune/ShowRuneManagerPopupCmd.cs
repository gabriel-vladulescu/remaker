using Ssar.Rune.Model;

namespace Ssar.Rune
{
	public class ShowRuneManagerPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public Ssar.Rune.Model.Rune rune { get; set; }

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
