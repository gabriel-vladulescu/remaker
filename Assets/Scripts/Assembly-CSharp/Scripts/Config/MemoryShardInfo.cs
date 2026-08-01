namespace Scripts.Config
{
	public class MemoryShardInfo
	{
		public int mirror { get; set; }

		public int shard { get; set; }

		public string node { get; set; }

		public int rate { get; set; }

		public ConfigWithCharacter texturePath { get; set; }

		public string GetTexturePath(int groupId, int subId)
		{
			return null;
		}
	}
}
