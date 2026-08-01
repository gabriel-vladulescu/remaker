using SSAR.Equipment.Enum;

namespace Scripts.Config
{
	public class PetVisualAvailableInfo
	{
		public int visualId;

		public int groupId;

		public int subId;

		public string rarity;

		public string icon;

		public string localizeName;

		public string visualFolderParent;

		public string prefabPath;

		public string[] visualCategory;

		public Rarity Rarity => default(Rarity);

		public string GetPath()
		{
			return null;
		}
	}
}
