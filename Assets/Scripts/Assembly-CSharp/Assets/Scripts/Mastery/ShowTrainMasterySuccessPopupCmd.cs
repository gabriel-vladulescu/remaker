using Scripts.Config;

namespace Assets.Scripts.Mastery
{
	public class ShowTrainMasterySuccessPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public MasteryInfo MasteryInfo { get; set; }

		[Inject]
		public float levelProgress { get; set; }

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
