using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Dungeon.Configs
{
	public interface Gate
	{
		int Id();

		string ClassName();

		IEnumerable<string> CookiesList();
	}
}
