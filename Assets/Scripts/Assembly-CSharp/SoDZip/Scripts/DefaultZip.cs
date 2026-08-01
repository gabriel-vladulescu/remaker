using System.IO;

namespace SoDZip.Scripts
{
	public class DefaultZip : IZip
	{
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

		private void CopyTo(Stream source, Stream destination)
		{
		}
	}
}
