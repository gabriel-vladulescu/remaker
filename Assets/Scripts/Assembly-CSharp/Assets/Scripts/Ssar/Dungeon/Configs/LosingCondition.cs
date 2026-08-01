using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Dungeon.Configs
{
	public interface LosingCondition
	{
		string Name();

		string ClassName();

		IEnumerable<string> CookiesList();
	}
}
