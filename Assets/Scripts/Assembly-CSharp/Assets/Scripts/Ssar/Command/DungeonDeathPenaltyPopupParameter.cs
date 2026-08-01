using System;

namespace Assets.Scripts.Ssar.Command
{
	public class DungeonDeathPenaltyPopupParameter
	{
		public Action confirmCallBack;

		public DungeonDeathPenaltyType type;

		public DungeonDeathPenaltyPopupParameter(Action confirmCallBack, DungeonDeathPenaltyType type)
		{
		}

		public DungeonDeathPenaltyPopupParameter(DungeonDeathPenaltyType type)
		{
		}
	}
}
