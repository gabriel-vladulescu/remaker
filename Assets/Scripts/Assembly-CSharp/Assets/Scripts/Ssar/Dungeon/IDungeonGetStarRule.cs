namespace Assets.Scripts.Ssar.Dungeon
{
	public interface IDungeonGetStarRule
	{
		bool IsComplete();

		string Description();

		int Priority();
	}
}
