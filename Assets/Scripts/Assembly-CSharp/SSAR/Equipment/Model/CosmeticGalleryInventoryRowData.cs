using System.Collections.Generic;

namespace SSAR.Equipment.Model
{
	public class CosmeticGalleryInventoryRowData : WrapContentData
	{
		public List<ICosmeticGalleryItemData> ItemInfos;

		public CosmeticGalleryInventoryRowData(List<ICosmeticGalleryItemData> itemInfos)
		{
		}
	}
}
