using System.Collections.Generic;
using Assets.Scripts.Ssar.DataManager;

namespace SSAR.BattleSystem.System.Arena
{
	public class CheatCheckingLogic
	{
		private interface Criteria
		{
			float Evaluate();
		}

		private float threshold;

		private List<PurchasedProduct> purchasedProducts;

		private MainCharacterData mainCharacterData;

		private List<Criteria> criteriaList;

		public CheatCheckingLogic(List<PurchasedProduct> purchasedProducts, MainCharacterData mainCharacterData)
		{
		}

		public bool IsCheating()
		{
			return false;
		}
	}
}
