using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Tutorial
{
	public class TutorialGroup4 : ITutorialGroup
	{
		private TutorialStage stage1;

		private TutorialStage stage2;

		private TutorialStage stage3;

		private List<TutorialStage> stages;

		public TutorialGroup4(string name, MainCharacterData mainCharacterData)
			: base(null, null)
		{
		}

		private void UpdatePopup()
		{
		}

		private void Prepare(TutorialKey key, TutorialStage stage)
		{
		}

		private new void Complete()
		{
		}

		public override bool Condition(TutorialKey fromKey)
		{
			return false;
		}

		private AbsCharacterDialogTutorialGroup4 Dialog()
		{
			return null;
		}

		public override bool IsErrorData()
		{
			return false;
		}

		private void ForceCompleteStage()
		{
		}
	}
}
