using Artemis;
using Assets.Scripts.Ssar.Common.System.Resources;
using Scripts.Config;
using UnityEngine;

namespace Scripts.Ssar.Pet
{
	public class SummonPet
	{
		private readonly PetCollectData petData;

		private readonly MainCharacterData mainCharacterData;

		private readonly string group;

		private readonly Entity main;

		private ResourcesLoader ResourcesLoader { get; set; }

		private ConfigManager ConfigManager { get; set; }

		public SummonPet(PetCollectData petData, MainCharacterData mainCharacterData, string group, ResourcesLoader resourcesLoader, ConfigManager configManager, Entity main)
		{
		}

		public void Execute()
		{
		}

		private void Summon(PetVisualAvailableInfo petInfo)
		{
		}

		private void LoadPrefabSuccess(GameObject prefab, PetVisualAvailableInfo petInfo)
		{
		}

		private Vector3 Pos(AbsHeroData heroData)
		{
			return default(Vector3);
		}

		private PetVisualAvailableInfo GetPetInfo()
		{
			return null;
		}
	}
}
