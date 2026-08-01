using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Tutorial
{
	public abstract class AbsCharacterDialogTutorialGroup4
	{
		protected ITutorialGroup tutorialGroup;

		public AbsCharacterDialogTutorialGroup4(ITutorialGroup tutorialGroup)
		{
		}

		public abstract List<DialogTutParameter> DialogOnShowMain();

		public abstract List<DialogTutParameter> DialogOnShowInventory();

		public abstract List<DialogTutParameter> DialogAfterTrainMastery();
	}
}
