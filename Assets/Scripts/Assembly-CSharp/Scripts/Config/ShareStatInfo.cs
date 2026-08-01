using Scripts.Ssar.Pet;

namespace Scripts.Config
{
	public class ShareStatInfo
	{
		public int id;

		public string shareStatType;

		public bool alwayHas;

		public string descLocalize;

		public string nameLocalize;

		public ShareStatType ShareStatType => default(ShareStatType);
	}
}
