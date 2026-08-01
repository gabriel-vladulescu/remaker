using System.Collections.Generic;
using Assets.Scripts.Ssar.CharacterSelection.Model;

namespace Scripts.Config
{
	public class CharacterSelectionConfig : IConfig
	{
		public Dictionary<string, CharacterInitData> characterInit;

		public Dictionary<string, CharacterInitData> characterInitDemo;

		public Dictionary<string, CharacterInitData> characterInitPaid;

		public Dictionary<string, CharacterSelectionElementInfo> info;

		private List<CharacterSelectionElementInfo> ret;

		public void OnMapValue(string content)
		{
		}

		public CharacterCode GetCharacterNewest()
		{
			return default(CharacterCode);
		}

		public CharacterSelectionElementInfo GetCharacterSelectionElementInfo(int groupId)
		{
			return null;
		}

		public List<CharacterSelectionElementInfo> GetCharacterSelectionElementInfos()
		{
			return null;
		}

		public bool FindCharacterElementInfoBySku(string sku, ref CharacterSelectionElementInfo productInfo)
		{
			return false;
		}

		public List<string> GetAllSkus()
		{
			return null;
		}

		public CharacterInitData GetCharacterInitData(int groupId, int subId)
		{
			return null;
		}

		public CharacterInitData GetCharacterInitDemoData(int groupId, int subId)
		{
			return null;
		}

		public CharacterInitData GetCharacterInitPaidData(int groupId, int subId)
		{
			return null;
		}

		private int Comparer(CharacterSelectionElementInfo a, CharacterSelectionElementInfo b)
		{
			return 0;
		}
	}
}
