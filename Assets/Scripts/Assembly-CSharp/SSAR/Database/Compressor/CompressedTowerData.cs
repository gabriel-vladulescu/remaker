using System;

namespace Ssar.Database.Compressor
{
	[Serializable]
	public class CompressedTowerData : BaseCompressedData
	{
		public override CompressedDataType Type()
		{
			return default(CompressedDataType);
		}

		public override void Compress(MainCharacterData characterData, int chuckSize)
		{
		}

		public override void Decompress(MainCharacterData characterData)
		{
		}
	}
}
