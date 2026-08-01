using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Dungeon.Configs
{
	public interface Goal
	{
		string ClassName();

		IEnumerable<string> CookiesList();
	}
}
