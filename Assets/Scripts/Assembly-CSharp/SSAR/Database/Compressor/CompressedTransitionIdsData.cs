using System;

namespace Ssar.Database.Compressor
{
	[Serializable]
	public class CompressedTransitionIdsData : BaseCompressedData
	{
		public override CompressedDataType Type()
		{
			return default(CompressedDataType);
		}

		public override void Compress(UserData userData, int chuckSize)
		{
		}

		public override void Decompress(UserData userData)
		{
		}

		private void RemoveUnusedData(UserData userData)
		{
		}
	}
}
