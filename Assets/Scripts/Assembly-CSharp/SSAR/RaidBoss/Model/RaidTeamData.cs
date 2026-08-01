using System.Collections.Generic;

namespace Ssar.RaidBoss.Model
{
	public class RaidTeamData
	{
		public class Companion
		{
			public MainCharacterData mainCharacterData;

			public int companionIndex;

			public Companion(MainCharacterData mainCharacterData, int companionIndex)
			{
			}
		}

		public MainCharacterData MainCharacterData;

		public List<Companion> Companions;
	}
}
