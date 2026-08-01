using System.Collections.Generic;

namespace Scripts.Config
{
	public class PiggyBankConfig : IConfig
	{
		public Dictionary<string, PiggyBankItem> soul;

		public Dictionary<string, PiggyBankItem> crystal;

		public void OnMapValue(string content)
		{
		}

		public List<string> GetAllSkus()
		{
			return null;
		}

		public bool GetPiggyBankItem(string sku, ref PiggyBankItem item)
		{
			return false;
		}

		public PiggyBankItem GetPiggyBankItem(PiggyBankType piggyBankType, int purchasedCount)
		{
			return null;
		}
	}
}
