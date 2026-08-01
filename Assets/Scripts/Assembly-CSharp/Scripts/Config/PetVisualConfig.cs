using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class PetVisualConfig : IConfig
	{
		public Dictionary<string, PetVisualAvailableInfo> pets;

		private Dictionary<string, List<PetVisualAvailableInfo>> dictVisualAvailableInfo;

		public void OnMapValue(string content)
		{
		}

		public List<PetVisualAvailableInfo> GetPetVisualAvailableInfosForRarity(Rarity rarity, string visualCategory)
		{
			return null;
		}

		public List<PetVisualAvailableInfo> GetPetVisualAvailableInfosForRarity(Rarity rarity)
		{
			return null;
		}

		public PetVisualAvailableInfo GetPetVisualAvailableInfoFromId(int groupId, int subId)
		{
			return null;
		}

		public PetVisualAvailableInfo GetPetVisualAvailableInfo(int visualId)
		{
			return null;
		}

		private void CacheDict()
		{
		}
	}
}
