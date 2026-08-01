using SevenZip;

namespace SoDZip.Scripts
{
	public class SevenZipAdapter : IZip
	{
		private static int dictionary;

		private static bool eos;

		private static CoderPropID[] propIDs;

		private static object[] properties;

		public byte[] Compress(string text)
		{
			return null;
		}

		public string Decompress(byte[] byteArray)
		{
			return null;
		}

		public ZipLibrary GetZipLibrary()
		{
			return default(ZipLibrary);
		}
	}
}
