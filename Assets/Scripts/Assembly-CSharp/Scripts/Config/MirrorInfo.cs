namespace Scripts.Config
{
	public class MirrorInfo
	{
		public int mirror { get; set; }

		public string nameLocalize { get; set; }

		public ConfigWithCharacter storyLocalize { get; set; }

		public bool available { get; set; }

		public string GetStoryLocalize(int groupId, int subId)
		{
			return null;
		}
	}
}
