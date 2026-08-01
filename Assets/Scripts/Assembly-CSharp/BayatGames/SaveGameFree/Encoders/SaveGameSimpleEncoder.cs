namespace BayatGames.SaveGameFree.Encoders
{
	public class SaveGameSimpleEncoder : ISaveGameEncoder
	{
		private const int Keysize = 256;

		private const int DerivationIterations = 1000;

		public string Encode(string input, string password)
		{
			return null;
		}

		public string Decode(string input, string password)
		{
			return null;
		}

		private static byte[] Generate256BitsOfRandomEntropy()
		{
			return null;
		}
	}
}
