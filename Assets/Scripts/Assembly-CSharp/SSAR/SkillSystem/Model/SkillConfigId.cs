namespace SSAR.SkillSystem.Model
{
	public class SkillConfigId
	{
		public int characterGroupId;

		public int characterSubId;

		public int skillId;

		private string configId;

		public int CharacterGroupId => 0;

		public int CharacterSubId => 0;

		public int SkillId => 0;

		public SkillConfigId(string configId)
		{
		}

		public SkillConfigId(int characterGroupId, int characterSubId, int skillId)
		{
		}

		public string ParseConfigId()
		{
			return null;
		}

		public bool Equals(SkillConfigId other)
		{
			return false;
		}

		private void InitConfigId()
		{
		}
	}
}
