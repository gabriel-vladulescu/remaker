using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Dungeon.Configs
{
	public interface Trigger
	{
		string ClassName();

		IEnumerable<string> CookiesList();
	}
}
