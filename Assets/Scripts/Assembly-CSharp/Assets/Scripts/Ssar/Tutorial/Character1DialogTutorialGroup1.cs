using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Tutorial
{
	public class Character1DialogTutorialGroup1 : AbsCharacterDialogTutorialGroup1
	{
		public Character1DialogTutorialGroup1(ITutorialGroup tutorialGroup)
			: base(null)
		{
		}

		public override List<DialogTutParameter> DialogOnShowMain()
		{
			return null;
		}

		public override List<DialogTutParameter> DialogOnShowInventory()
		{
			return null;
		}

		public override List<DialogTutParameter> DialogAfterEquip()
		{
			return null;
		}
	}
}
