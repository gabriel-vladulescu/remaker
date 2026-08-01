namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class DoNothingSpawnedMonsterList : InitDungeonSystemCmd.SpawnedMonsterList
	{
		public DoNothingSpawnedMonsterList(Dungeon dungeon)
			: base(null)
		{
		}

		public override int ObtainTicket()
		{
			return 0;
		}
	}
}
