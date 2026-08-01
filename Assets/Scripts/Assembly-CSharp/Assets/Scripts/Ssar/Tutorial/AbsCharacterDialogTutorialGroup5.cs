using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Tutorial
{
	public abstract class AbsCharacterDialogTutorialGroup5
	{
		protected ITutorialGroup tutorialGroup;

		public AbsCharacterDialogTutorialGroup5(ITutorialGroup tutorialGroup)
		{
		}

		public abstract List<DialogTutParameter> DialogOnShowMain();

		public abstract List<DialogTutParameter> DialogOnShowChallengeMap();

		public abstract List<DialogTutParameter> DialogOnShowJoinSeason();

		public abstract List<DialogTutParameter> DialogFinishJoinSeason();

		public abstract List<DialogTutParameter> DialogShowReward();

		public abstract List<DialogTutParameter> DialogStartBattle();
	}
}
