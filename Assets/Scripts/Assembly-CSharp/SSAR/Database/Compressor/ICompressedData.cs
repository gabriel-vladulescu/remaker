namespace Ssar.Database.Compressor
{
	public interface ICompressedData
	{
		CompressedDataType Type();

		void Compress(MainCharacterData characterData, int chuckSize);

		void Compress(UserData userData, int chuckSize);

		void Decompress(MainCharacterData characterData);

		void Decompress(UserData userData);

		bool IsValid();
	}
}
