using SSAR.Equipment.Model;
using Scripts.Ssar.Pet;
using Ssar.Achievement;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Pet.Command
{
	public class EquipEquipmentForPetCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public EquipmentCollectData EquipmentCollectData { get; set; }

		[Inject]
		public PetCollectData PetCollectData { get; set; }

		[Inject]
		public AchievementLogic achievementLogic { get; set; }

		public override void Execute()
		{
		}

		private UISfx GetSfx(EquipmentCategory category)
		{
			return default(UISfx);
		}
	}
}
