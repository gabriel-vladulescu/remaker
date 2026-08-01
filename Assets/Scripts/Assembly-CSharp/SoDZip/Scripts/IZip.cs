namespace SoDZip.Scripts
{
	public interface IZip
	{
		byte[] Compress(string text);

		string Decompress(byte[] byteArray);

		ZipLibrary GetZipLibrary();
	}
}
