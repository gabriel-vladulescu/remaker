using System;
using System.Collections.Generic;
using LitJson;

namespace Ssar.Database.Compressor
{
	[Serializable]
	public class UserCompressedData
	{
		[JsonInclude]
		private Dictionary<string, BaseCompressedData> compressedDatas;

		public void AddCompressedData(BaseCompressedData compressedData)
		{
		}

		public List<BaseCompressedData> GetAllCompressedDatas()
		{
			return null;
		}

		public BaseCompressedData GetCompressedData(CompressedDataType type)
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
