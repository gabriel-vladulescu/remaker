using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Tutorial
{
	public class Character1DialogTutorialGroup2 : AbsCharacterDialogTutorialGroup2
	{
		public Character1DialogTutorialGroup2(ITutorialGroup tutorialGroup)
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

		public override List<DialogTutParameter> DialogAfterEnhanceEquipment()
		{
			return null;
		}
	}
}
