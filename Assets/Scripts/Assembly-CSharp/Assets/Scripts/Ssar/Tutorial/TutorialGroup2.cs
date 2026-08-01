namespace Assets.Scripts.Ssar.Tutorial
{
	public class TutorialGroup2 : ITutorialGroup
	{
		private TutorialStage stage1;

		private TutorialStage stage2;

		private TutorialStage stage3;

		public TutorialGroup2(string name, MainCharacterData mainCharacterData)
			: base(null, null)
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

		private void CompleteBack(TutorialKey key, TutorialStage stage)
		{
		}

		private AbsCharacterDialogTutorialGroup2 Dialog()
		{
			return null;
		}

		public override bool Condition(TutorialKey fromKey)
		{
			return false;
		}

		private void ForceCompleteStage(TutorialKey key, TutorialStage stage)
		{
		}
	}
}
