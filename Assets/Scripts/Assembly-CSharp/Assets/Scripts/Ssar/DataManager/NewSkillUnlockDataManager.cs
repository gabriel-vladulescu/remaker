using System.Collections.Generic;
using Scripts.Config;

namespace Assets.Scripts.Ssar.DataManager
{
	public class NewSkillUnlockDataManager
	{
		private List<ISkillStat> activeUnlocked;

		private List<ISkillStat> signatureUnlocked;

		private List<ISkillStat> passiveUnlocked;

		public void LevelUp(int levelBefore, int levelAfter)
		{
		}

		public List<ISkillStat> GetListActiveSkillUnlocked()
		{
			return null;
		}

		public List<ISkillStat> GetListSignatureSkillUnlocked()
		{
			return null;
		}

		public List<ISkillStat> GetListPassiveSkillUnlocked()
		{
			return null;
		}

		public void SetHasSeenActiveSkill()
		{
		}

		public void SetHasSeenSignatureSkill()
		{
		}

		public void SetHasSeenPassiveSKill()
		{
		}
	}
}
