using Ssar.Rune.Model;

namespace Ssar.Rune
{
	public class ShowCombineRunePopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public Ssar.Rune.Model.Rune Rune { get; set; }

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
