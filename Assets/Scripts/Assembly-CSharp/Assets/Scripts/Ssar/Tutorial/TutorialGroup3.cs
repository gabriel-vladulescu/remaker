namespace Assets.Scripts.Ssar.Tutorial
{
	public class TutorialGroup3 : ITutorialGroup
	{
		private TutorialStage stage1;

		private TutorialStage stage2;

		private TutorialStage stage3;

		public TutorialGroup3(string name, MainCharacterData mainCharacterData)
			: base(null, null)
		{
		}

		public override bool Condition(TutorialKey fromKey)
		{
			return false;
		}

		private void Dialog3()
		{
		}

		private new void Complete()
		{
		}

		public override bool IsErrorData()
		{
			return false;
		}

		private void Start()
		{
		}

		private void Upgrade()
		{
		}

		private void Reward()
		{
		}

		private void ForceCompleteStage()
		{
		}

		private AbsCharacterDialogTutorialGroup3 GetDialog()
		{
			return null;
		}

		private void CompleteStep5(TutorialKey key, TutorialStage stage)
		{
		}
	}
}
