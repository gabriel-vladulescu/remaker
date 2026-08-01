using System.Collections.Generic;

namespace Scripts.Config
{
	public class MemoryShardConfig : IConfig
	{
		public Dictionary<string, MemoryShardInfo> shards;

		public Dictionary<string, MirrorInfo> mirrors;

		public Dictionary<string, ClipInfo> clips;

		private Dictionary<int, List<MemoryShardInfo>> mirrorToShardList;

		private List<MirrorInfo> m_mirror;

		private List<ClipInfo> clipInfos;

		public void OnMapValue(string content)
		{
		}

		public MirrorInfo GetMirrorInfo(int mirrorId)
		{
			return null;
		}

		public List<MirrorInfo> GetMirrorInfos()
		{
			return null;
		}

		public MemoryShardInfo GetShardDropByDungeon(int nodeId)
		{
			return null;
		}

		public List<MemoryShardInfo> GetListShardInfos(int mirrorId)
		{
			return null;
		}

		public List<ClipInfo> GetClipInfos()
		{
			return null;
		}

		private int Comparer(ClipInfo a, ClipInfo b)
		{
			return 0;
		}

		private int Comparer(MirrorInfo a, MirrorInfo b)
		{
			return 0;
		}

		public MemoryShardInfo GetShardInfo(int mirrorId, int shardId)
		{
			return null;
		}
	}
}
