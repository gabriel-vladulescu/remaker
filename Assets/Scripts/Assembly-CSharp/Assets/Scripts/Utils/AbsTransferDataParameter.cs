using Scripts.Config;
using Scripts.Config.Stats;

namespace Assets.Scripts.Utils
{
	public abstract class AbsTransferDataParameter
	{
		public AbsStats source;

		public EntityAbilities target;

		public AbsTransferDataParameter(AbsStats source, EntityAbilities target)
		{
		}

		public abstract object Plus(object vSource, object vTarget);

		public abstract object Minus(object vSource, object vTarget);

		public abstract object PlusPercent(object vSource, object vTarget);

		public abstract object MinusPercent(object vSource, object vTarget);
	}
}
