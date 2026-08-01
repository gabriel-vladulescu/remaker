using System.Collections.Generic;
using Assets.Scripts.Utils;
using SSAR.Equipment.Model;
using Scripts.Config;
using Scripts.Config.Stats;
using Scripts.Ssar.Pet;

namespace Assets.Scripts.Config.Stats
{
	public class PetData : AbsHeroData
	{
		private ConfigManager configManager;

		public PetCollectData PetCollectData;

		private List<EquipmentCollectData> equipmentCollectDatas;

		public PetData(int groupId, int subId, int level, PetCollectData petCollectData, ConfigManager configManager)
			: base(0, 0, 0)
		{
		}

		public PetData SetEquipment(List<EquipmentCollectData> equipmentCollectDatas)
		{
			return null;
		}

		public override EntityAbilities GetTotalStats()
		{
			return null;
		}

		public override HeroBasicStats GetHeroBasicStats()
		{
			return null;
		}

		public override HeroLevelStats GetHeroLevelStats()
		{
			return null;
		}

		protected GetBasicAbilitiesParameter GetBasicAbilitiesParameter()
		{
			return null;
		}
	}
}
