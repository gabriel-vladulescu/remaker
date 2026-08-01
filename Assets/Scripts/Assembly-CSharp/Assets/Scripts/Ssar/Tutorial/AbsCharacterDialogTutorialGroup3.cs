using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Tutorial
{
	public abstract class AbsCharacterDialogTutorialGroup3
	{
		protected ITutorialGroup tutorialGroup;

		public AbsCharacterDialogTutorialGroup3(ITutorialGroup tutorialGroup)
		{
		}

		public abstract List<DialogTutParameter> DialogOnShowSkillPopup();

		public abstract List<DialogTutParameter> DialogAfterUpgradeSkill();
	}
}
