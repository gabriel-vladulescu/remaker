using System;
using System.Collections.Generic;
using LitJson;
using SoDZip.Scripts;

namespace Ssar.Database.Compressor
{
	[Serializable]
	public class BaseCompressedData : ICompressedData
	{
		[JsonInclude]
		protected ZipLibrary zLib;

		[JsonInclude]
		protected List<string> values;

		[JsonInclude]
		protected string value;

		[JsonInclude]
		protected int chuckSize;

		public virtual CompressedDataType Type()
		{
			return default(CompressedDataType);
		}

		public virtual void Compress(MainCharacterData characterData, int chuckSize)
		{
		}

		public virtual void Compress(UserData userData, int chuckSize)
		{
		}

		public virtual void Decompress(MainCharacterData characterData)
		{
		}

		public virtual void Decompress(UserData userData)
		{
		}

		public virtual bool IsValid()
		{
			return false;
		}

		private bool IsArrayValueValid()
		{
			return false;
		}

		private bool IsValueValid()
		{
			return false;
		}

		protected void CompressToString(object data, int chuckSize)
		{
		}

		private void CompressToArrayString(string jsonValue, int chuckSize)
		{
		}

		protected bool Decompress<T>(ref T output)
		{
			return false;
		}
	}
}
