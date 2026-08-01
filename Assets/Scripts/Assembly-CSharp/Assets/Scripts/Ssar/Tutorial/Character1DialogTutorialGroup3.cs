using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Tutorial
{
	public class Character1DialogTutorialGroup3 : AbsCharacterDialogTutorialGroup3
	{
		public Character1DialogTutorialGroup3(ITutorialGroup tutorialGroup)
			: base(null)
		{
		}

		public override List<DialogTutParameter> DialogOnShowSkillPopup()
		{
			return null;
		}

		public override List<DialogTutParameter> DialogAfterUpgradeSkill()
		{
			return null;
		}
	}
}
