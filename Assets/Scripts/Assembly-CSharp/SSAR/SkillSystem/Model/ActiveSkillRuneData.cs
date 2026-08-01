using System;
using SSAR.SkillSystem.Utils;

namespace SSAR.SkillSystem.Model
{
	[Serializable]
	public class ActiveSkillRuneData
	{
		public int arcaneRuneLevel;

		public int tacticRuneLevel;

		public int powerRuneLevel;

		public int GetRuneLevel(RuneType runeType)
		{
			return 0;
		}

		public void SetRunLevel(RuneType runeType, int level)
		{
		}
	}
}
