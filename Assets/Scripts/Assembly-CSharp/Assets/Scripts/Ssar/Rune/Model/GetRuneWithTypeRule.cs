using Assets.Scripts.Ssar.Rune.Enum;
using SSAR.Equipment.View;

namespace Assets.Scripts.Ssar.Rune.Model
{
	public class GetRuneWithTypeRule : IGetCollectDataRule
	{
		private RuneInventoryTabType type;

		public GetRuneWithTypeRule(RuneInventoryTabType type)
		{
		}

		public bool IsSuitableConditions(ICollectData collectData)
		{
			return false;
		}

		private bool IsSameType(ICollectData collectData)
		{
			return false;
		}
	}
}
