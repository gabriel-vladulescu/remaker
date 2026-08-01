using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using BayatGames.SaveGameFree.Encoders;
using BayatGames.SaveGameFree.Serializers;

namespace BayatGames.SaveGameFree
{
	public static class SaveGame
	{
		public delegate void SaveHandler(object obj, string identifier, bool encode, string password, ISaveGameSerializer serializer, ISaveGameEncoder encoder, Encoding encoding, SaveGamePath path);

		public delegate void LoadHandler(object loadedObj, string identifier, bool encode, string password, ISaveGameSerializer serializer, ISaveGameEncoder encoder, Encoding encoding, SaveGamePath path);

		public static SaveHandler SaveCallback;

		public static LoadHandler LoadCallback;

		private static ISaveGameSerializer m_Serializer;

		private static ISaveGameEncoder m_Encoder;

		private static Encoding m_Encoding;

		private static bool m_Encode;

		private static SaveGamePath m_SavePath;

		private static string m_EncodePassword;

		private static bool m_LogError;

		public static ISaveGameSerializer Serializer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static ISaveGameEncoder Encoder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Encoding DefaultEncoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool Encode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static SaveGamePath SavePath
		{
			get
			{
				return default(SaveGamePath);
			}
			set
			{
			}
		}

		public static string EncodePassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool LogError
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static event SaveHandler OnSaved
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event LoadHandler OnLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static void Save<T>(string identifier, T obj)
		{
		}

		public static void Save<T>(string identifier, T obj, bool encode)
		{
		}

		public static void Save<T>(string identifier, T obj, string encodePassword)
		{
		}

		public static void Save<T>(string identifier, T obj, ISaveGameSerializer serializer)
		{
		}

		public static void Save<T>(string identifier, T obj, ISaveGameEncoder encoder)
		{
		}

		public static void Save<T>(string identifier, T obj, Encoding encoding)
		{
		}

		public static void Save<T>(string identifier, T obj, SaveGamePath savePath)
		{
		}

		public static void Save<T>(string identifier, T obj, bool encode, string password, ISaveGameSerializer serializer, ISaveGameEncoder encoder, Encoding encoding, SaveGamePath path)
		{
		}

		public static T Load<T>(string identifier)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, T defaultValue)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, bool encode, string encodePassword)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, ISaveGameSerializer serializer)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, ISaveGameEncoder encoder)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, Encoding encoding)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, SaveGamePath savePath)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, T defaultValue, bool encode)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, T defaultValue, string encodePassword)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, T defaultValue, ISaveGameSerializer serializer)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, T defaultValue, ISaveGameEncoder encoder)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, T defaultValue, Encoding encoding)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, T defaultValue, SaveGamePath savePath)
		{
			return default(T);
		}

		public static T Load<T>(string identifier, T defaultValue, bool encode, string password, ISaveGameSerializer serializer, ISaveGameEncoder encoder, Encoding encoding, SaveGamePath path)
		{
			return default(T);
		}

		public static bool Exists(string identifier)
		{
			return false;
		}

		public static bool Exists(string identifier, SaveGamePath path)
		{
			return false;
		}

		public static void Delete(string identifier)
		{
		}

		public static void Delete(string identifier, SaveGamePath path)
		{
		}

		public static void Clear()
		{
		}

		public static void Clear(SaveGamePath path)
		{
		}

		public static void DeleteAll()
		{
		}

		public static void DeleteAll(SaveGamePath path)
		{
		}

		public static FileInfo[] GetFiles()
		{
			return null;
		}

		public static FileInfo[] GetFiles(string identifier)
		{
			return null;
		}

		public static FileInfo[] GetFiles(string identifier, SaveGamePath path)
		{
			return null;
		}

		public static DirectoryInfo[] GetDirectories()
		{
			return null;
		}

		public static DirectoryInfo[] GetDirectories(string identifier)
		{
			return null;
		}

		public static DirectoryInfo[] GetDirectories(string identifier, SaveGamePath path)
		{
			return null;
		}

		public static bool IOSupported()
		{
			return false;
		}

		public static bool IsFilePath(string str)
		{
			return false;
		}
	}
}
