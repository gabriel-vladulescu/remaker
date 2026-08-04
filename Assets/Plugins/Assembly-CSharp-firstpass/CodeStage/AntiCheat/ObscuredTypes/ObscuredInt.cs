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
			currentCryptoKey = cryptoKey;
			hiddenValue = value ^ currentCryptoKey;
			fakeValue = value;
			inited = true;
		}

		public static void SetNewCryptoKey(int newKey)
		{
			cryptoKey = newKey;
		}

		public static int Encrypt(int value)
		{
			return Encrypt(value, cryptoKey);
		}

		public static int Encrypt(int value, int key)
		{
			return value ^ key;
		}

		public static int Decrypt(int value)
		{
			return Decrypt(value, cryptoKey);
		}

		public static int Decrypt(int value, int key)
		{
			return value ^ key;
		}

		public void ApplyNewCryptoKey()
		{
			if (inited)
			{
				int decrypted = InternalDecrypt();
				currentCryptoKey = cryptoKey;
				hiddenValue = decrypted ^ currentCryptoKey;
			}
		}

		public void RandomizeCryptoKey()
		{
			SetNewCryptoKey(UnityEngine.Random.Range(int.MinValue, int.MaxValue));
			ApplyNewCryptoKey();
		}

		public int GetEncrypted()
		{
			return hiddenValue;
		}

		public void SetEncrypted(int encrypted)
		{
			currentCryptoKey = cryptoKey;
			hiddenValue = encrypted;
			fakeValue = InternalDecrypt();
			inited = true;
		}

		public int GetDecrypted()
		{
			return InternalDecrypt();
		}

		private int InternalDecrypt()
		{
			if (!inited)
			{
				return 0;
			}
			return hiddenValue ^ currentCryptoKey;
		}

		public static implicit operator ObscuredInt(int value)
		{
			return new ObscuredInt(value);
		}

		public static implicit operator int(ObscuredInt value)
		{
			return value.InternalDecrypt();
		}

		public static implicit operator ObscuredFloat(ObscuredInt value)
		{
			return value.InternalDecrypt();
		}

		public static implicit operator ObscuredDouble(ObscuredInt value)
		{
			return value.InternalDecrypt();
		}

		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return (uint)value.InternalDecrypt();
		}

		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return new ObscuredInt(input.InternalDecrypt() + 1);
		}

		public static ObscuredInt operator --(ObscuredInt input)
		{
			return new ObscuredInt(input.InternalDecrypt() - 1);
		}

		public override bool Equals(object obj)
		{
			return obj is ObscuredInt other && Equals(other);
		}

		public bool Equals(ObscuredInt obj)
		{
			return InternalDecrypt() == obj.InternalDecrypt();
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}

		public override string ToString()
		{
			return InternalDecrypt().ToString();
		}

		public string ToString(string format)
		{
			return InternalDecrypt().ToString(format);
		}

		public string ToString(IFormatProvider provider)
		{
			return InternalDecrypt().ToString(provider);
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return InternalDecrypt().ToString(format, provider);
		}
	}
}
