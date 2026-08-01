using System.Collections.Generic;
using Artemis;
using Artemis.Interface;
using Scripts.Ssar.Pet;

namespace SSAR.Dungeon.Caching
{
	public class PetListComponent : IComponent
	{
		public List<PetCollectData> PetCollectDatas;

		private List<Entity> petEntities;

		public void AddPetData(PetCollectData petCollectData)
		{
		}

		public void AddPetEntity(Entity pet)
		{
		}

		public List<Entity> GetPets()
		{
			return null;
		}
	}
}
