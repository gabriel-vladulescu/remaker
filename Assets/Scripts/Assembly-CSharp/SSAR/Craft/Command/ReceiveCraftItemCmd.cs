using SSAR.Equipment.Model;
using Ssar.Craft.Model;
using Ssar.DailyQuest;
using Ssar.Rune.Model;
using strange.extensions.command.impl;

namespace Ssar.Craft.Command
{
	public class ReceiveCraftItemCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public ReceiveCraftItemParams Params { get; set; }

		[Inject]
		public DailyQuestLogic dql { get; set; }

		[Inject]
		public OnCraftItemSuccessSignal OnCraftItemSuccessSignal { get; set; }

		public override void Execute()
		{
		}

		private void Craft(CraftItemProgress progress)
		{
		}

		private void CraftNewEquipment(EquipmentCollectData rawEquipment)
		{
		}

		private void CraftNewRune(Ssar.Rune.Model.Rune rawRune)
		{
		}
	}
}
