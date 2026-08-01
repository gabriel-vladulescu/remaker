using SSAR.View;
using Ssar.Rune.Model;

namespace Assets.Scripts.Ssar.Rune.View
{
	public class RuneInventoryTabNotify : AbsButtonNofity
	{
		public RuneType RuneType;

		protected override bool IsNotify()
		{
			return false;
		}
	}
}
