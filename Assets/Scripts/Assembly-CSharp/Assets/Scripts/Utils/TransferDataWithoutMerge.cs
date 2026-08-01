using Scripts.Config;
using Scripts.Config.Stats;

namespace Assets.Scripts.Utils
{
	public class TransferDataWithoutMerge : AbsTransferDataParameter
	{
		public TransferDataWithoutMerge(AbsStats source, EntityAbilities target)
			: base(null, null)
		{
		}

		public override object Plus(object vSource, object vTarget)
		{
			return null;
		}

		public override object Minus(object vSource, object vTarget)
		{
			return null;
		}

		public override object PlusPercent(object vSource, object vTarget)
		{
			return null;
		}

		public override object MinusPercent(object vSource, object vTarget)
		{
			return null;
		}
	}
}
