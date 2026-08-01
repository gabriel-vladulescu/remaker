using System.IO;
using System.Text;

namespace BayatGames.SaveGameFree.Serializers
{
	public class SaveGameJsonSerializer : ISaveGameSerializer
	{
		public void Serialize<T>(T obj, Stream stream, Encoding encoding)
		{
		}

		public T Deserialize<T>(Stream stream, Encoding encoding)
		{
			return default(T);
		}
	}
}
