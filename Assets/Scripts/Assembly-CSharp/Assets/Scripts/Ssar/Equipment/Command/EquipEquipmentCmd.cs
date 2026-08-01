using Ssar.Achievement;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Equipment.Command
{
	public class EquipEquipmentCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public AbsEquipItemLogic item { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		public override void Execute()
		{
		}
	}
}
