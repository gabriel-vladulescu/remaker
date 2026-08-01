namespace Assets.Scripts.Ssar.Dungeon.Environment.Monster
{
	public interface Monster
	{
		float DeadTime();

		MonsterType Type();

		string ConfigId();

		int SpawnId();
	}
}
