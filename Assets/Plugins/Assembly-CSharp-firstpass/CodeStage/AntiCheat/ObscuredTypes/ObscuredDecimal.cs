using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDecimal : IEquatable<ObscuredDecimal>, IFormattable
	{
		[StructLayout((LayoutKind)2)]
		private struct DecimalLongBytesUnion
		{
			[FieldOffset(0)]
			public decimal d;

			[FieldOffset(0)]
			public long l1;

			[FieldOffset(8)]
			public long l2;

			[FieldOffset(0)]
			public ACTkByte16 b16;
		}

		private static long cryptoKey;

		private long currentCryptoKey;

		[FormerlySerializedAs("hiddenValue")]
		private byte[] hiddenValueOld;

		private ACTkByte16 hiddenValue;

		private decimal fakeValue;

		private bool inited;

		private ObscuredDecimal(ACTkByte16 value)
		{
			currentCryptoKey = 0L;
			hiddenValueOld = null;
			hiddenValue = default(ACTkByte16);
			fakeValue = default(decimal);
			inited = false;
		}

		public static void SetNewCryptoKey(long newKey)
		{
		}

		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		private static ACTkByte16 InternalEncrypt(decimal value)
		{
			return default(ACTkByte16);
		}

		private static ACTkByte16 InternalEncrypt(decimal value, long key)
		{
			return default(ACTkByte16);
		}

		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		public void SetEncrypted(decimal encrypted)
		{
		}

		public decimal GetDecrypted()
		{
			return default(decimal);
		}

		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
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

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredDecimal obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
