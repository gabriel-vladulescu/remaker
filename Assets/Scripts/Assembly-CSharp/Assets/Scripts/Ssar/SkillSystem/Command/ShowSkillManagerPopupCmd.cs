using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.SkillSystem.Command
{
	public class ShowSkillManagerPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public MainCharacterData MainCharacterData { get; set; }

		[Inject]
		public bool allowEdit { get; set; }

		[Inject]
		public Preset Preset { get; set; }

		[Inject]
		public Metric Metric { get; set; }

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
