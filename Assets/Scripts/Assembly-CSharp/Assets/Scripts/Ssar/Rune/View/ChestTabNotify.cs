using SSAR.Entry.Model;
using SSAR.View;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class ChestTabNotify : AbsButtonNofity
	{
		public ChestTabType ChestTabType;

		protected override bool IsNotify()
		{
			return false;
		}
	}
}
