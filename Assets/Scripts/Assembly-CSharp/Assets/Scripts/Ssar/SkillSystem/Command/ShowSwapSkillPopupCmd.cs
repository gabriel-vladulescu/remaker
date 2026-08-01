namespace Assets.Scripts.Ssar.SkillSystem.Command
{
	public class ShowSwapSkillPopupCmd : BaseShowPopupCmd
	{
		[Inject]
		public MainCharacterData MainCharacterData { get; set; }

		[Inject]
		public Preset Preset { get; set; }

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
