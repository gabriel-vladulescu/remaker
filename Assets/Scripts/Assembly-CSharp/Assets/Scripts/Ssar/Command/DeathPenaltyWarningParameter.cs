using System;

namespace Assets.Scripts.Ssar.Command
{
	public class DeathPenaltyWarningParameter
	{
		public Action confirmCallBack;

		public DeathPenaltyWarningType type;

		public DeathPenaltyWarningParameter(Action confirmCallBack, DeathPenaltyWarningType type)
		{
		}
	}
}
