using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Tutorial
{
	public abstract class AbsTutorialGroup0Logic
	{
		protected readonly TutorialGroup0 tutorialGroup0;

		public AbsTutorialGroup0Logic(TutorialGroup0 tutorialGroup0)
		{
		}

		protected TutorialStage AddStage(TutorialStage stage)
		{
			return null;
		}

		protected void NextStageDelegate(TutorialKey key, TutorialStage stage)
		{
		}

		protected List<TutorialStage> AddDialog(TutorialKey key, List<DialogTutParameter> parameters, bool require = true)
		{
			return null;
		}

		protected void EmptyDelegate(TutorialKey key, TutorialStage stage)
		{
		}

		protected void Complete()
		{
		}
	}
}
