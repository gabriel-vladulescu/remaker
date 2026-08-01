using System;

namespace Ssar.Database.Compressor
{
	[Serializable]
	public class DefaultCompressedData : BaseCompressedData
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

		public override bool IsValid()
		{
			return false;
		}
	}
}
