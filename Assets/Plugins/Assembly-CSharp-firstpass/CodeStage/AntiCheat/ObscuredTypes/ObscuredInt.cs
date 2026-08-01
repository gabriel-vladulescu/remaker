using System;
using LitJson;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredInt : IEquatable<ObscuredInt>, IFormattable
	{
		private static int cryptoKey;

		[SerializeField]
		[JsonInclude]
		private int currentCryptoKey;

		[JsonInclude]
		[SerializeField]
		private int hiddenValue;

		[SerializeField]
		[JsonInclude]
		private int fakeValue;

		[JsonInclude]
		[SerializeField]
		private bool inited;

		private ObscuredInt(int value)
		{
			currentCryptoKey = 0;
			hiddenValue = 0;
			fakeValue = 0;
			inited = false;
		}

		public static void SetNewCryptoKey(int newKey)
		{
		}

		public static int Encrypt(int value)
		{
			return 0;
		}

		public static int Encrypt(int value, int key)
		{
			return 0;
		}

		public static int Decrypt(int value)
		{
			return 0;
		}

		public static int Decrypt(int value, int key)
		{
			return 0;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public int GetEncrypted()
		{
			return 0;
		}

		public void SetEncrypted(int encrypted)
		{
		}

		public int GetDecrypted()
		{
			return 0;
		}

		private int InternalDecrypt()
		{
			return 0;
		}

		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		public static implicit operator int(ObscuredInt value)
		{
			return 0;
		}

		public static implicit operator ObscuredFloat(ObscuredInt value)
		{
			return default(ObscuredFloat);
		}

		public static implicit operator ObscuredDouble(ObscuredInt value)
		{
			return default(ObscuredDouble);
		}

		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredInt obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
}
