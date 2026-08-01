using Artemis.Blackboard;

public static class DungeonService
{
	private static BlackBoard blackBoard;

	static DungeonService()
	{
	}

	public static void SetEntry<T>(string name, T intel)
	{
	}

	public static T GetEntry<T>(string name)
	{
		return default(T);
	}

	public static void Clear()
	{
	}
}
