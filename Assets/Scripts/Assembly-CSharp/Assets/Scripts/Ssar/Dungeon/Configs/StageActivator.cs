using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Dungeon.Configs
{
	public interface StageActivator
	{
		int Id();

		string ClassName();

		IEnumerable<string> CookiesList();
	}
}
