using Assets.Scripts.Ssar.Dungeon.Model;
using Scripts.Config;

namespace Scripts.Ssar.Pet
{
	public class PetFindLevelStats : IFindLevelStats
	{
		private readonly int groupId;

		private readonly int subId;

		public PetFindLevelStats(int groupId, int subId)
		{
		}

		public HeroLevelStats HeroLevelStats()
		{
			return null;
		}
	}
}
