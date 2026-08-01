using System.Collections.Generic;
using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class AncientEnhancementConfig : IConfig
	{
		public Dictionary<string, AncientMaterialInfo> materials;

		public Dictionary<string, AncientExpInfo> rareExp;

		public Dictionary<string, AncientExpInfo> legendaryExp;

		public Dictionary<string, AncientExpInfo> ultimateExp;

		private Dictionary<Rarity, Dictionary<int, AncientExpInfo>> dict;

		public void OnMapValue(string content)
		{
		}

		private void MapExpInfo(Rarity rarity, Dictionary<string, AncientExpInfo> expInfos)
		{
		}

		private int Compare(AncientExpInfo a, AncientExpInfo b)
		{
			return 0;
		}

		public AncientExpInfo GetExpInfo(Rarity rarity, int level)
		{
			return null;
		}

		public List<AncientExpInfo> GetExpInfos(Rarity rarity)
		{
			return null;
		}

		public AncientMaterialInfo GetMaterialInfo(Rarity rarity)
		{
			return null;
		}
	}
}
