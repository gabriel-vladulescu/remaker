using System.Collections.Generic;

namespace Assets.Scripts.Config
{
	public interface RawLosingCondition
	{
		string Name();

		IEnumerable<string> Cookies();
	}
}
