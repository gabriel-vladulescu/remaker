using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Tutorial
{
	public abstract class AbsCharacterDialogTutorialGroup0
	{
		protected ITutorialGroup tutorialGroup;

		public AbsCharacterDialogTutorialGroup0(ITutorialGroup tutorialGroup)
		{
		}

		public abstract List<DialogTutParameter> DialogFinishClip();

		public abstract List<DialogTutParameter> DialogBeforeMove();

		public abstract List<DialogTutParameter> DialogBeforeAttack();

		public abstract List<DialogTutParameter> DialogAfterClearStage1();

		public abstract List<DialogTutParameter> DialogBeforeJump();

		public abstract List<DialogTutParameter> DialogBeforeSkill();

		public abstract List<DialogTutParameter> DialogAfterClearEnemey();

		public abstract List<DialogTutParameter> DialogAfterBossAppear();

		public abstract List<DialogTutParameter> DialogAfterBossHpTrigger();

		public abstract List<DialogTutParameter> DialogAfterBossStealth();
	}
}
