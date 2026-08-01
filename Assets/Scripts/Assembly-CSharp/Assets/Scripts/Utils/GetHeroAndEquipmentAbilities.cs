using System.Collections.Generic;
using Assets.Scripts.Config.Stats;
using Assets.Scripts.Mastery;
using SSAR.Equipment.Model;

namespace Assets.Scripts.Utils
{
	public class GetHeroAndEquipmentAbilities
	{
		public GetBasicAbilitiesParameter basic;

		public List<EquipmentCollectData> EquipmentCollectDatas;

		public PetData petData;

		public bool isHero;

		public MasteryData MasteryData { get; set; }

		public GetHeroAndEquipmentAbilities(GetBasicAbilitiesParameter basic, List<EquipmentCollectData> equipmentCollectDatas, MasteryData masteryData, PetData petData, bool isHero)
		{
		}
	}
}
