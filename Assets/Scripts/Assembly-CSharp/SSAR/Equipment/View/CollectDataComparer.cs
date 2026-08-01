using System.Collections;

namespace SSAR.Equipment.View
{
	public abstract class CollectDataComparer : IComparer
	{
		protected abstract int onCompare(ICollectData x, ICollectData y);

		public int Compare(object x, object y)
		{
			return 0;
		}
	}
}
