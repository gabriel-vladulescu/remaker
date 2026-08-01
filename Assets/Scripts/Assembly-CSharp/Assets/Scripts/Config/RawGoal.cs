using System.Collections.Generic;

namespace Assets.Scripts.Config
{
	public interface RawGoal
	{
		string Name();

		IEnumerable<string> Cookies();
	}
}
