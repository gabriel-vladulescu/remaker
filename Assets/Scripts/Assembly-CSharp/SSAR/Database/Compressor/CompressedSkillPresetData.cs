using System;
using LitJson;

namespace Ssar.Database.Compressor
{
	[Serializable]
	public class CompressedSkillPresetData : BaseCompressedData
	{
		[JsonInclude]
		private string pveValue;

		[JsonInclude]
		private string pvpValue;

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
