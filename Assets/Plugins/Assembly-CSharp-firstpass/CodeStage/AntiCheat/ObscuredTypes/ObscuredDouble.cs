using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDouble : IEquatable<ObscuredDouble>, IFormattable
	{
		[StructLayout((LayoutKind)2)]
		private struct DoubleLongBytesUnion
		{
			[FieldOffset(0)]
			public double d;

			[FieldOffset(0)]
			public long l;

			[FieldOffset(0)]
			public ACTkByte8 b8;
		}

		private static long cryptoKey;

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private ACTkByte8 hiddenValue;

		[SerializeField]
		[FormerlySerializedAs("hiddenValue")]
		private byte[] hiddenValueOld;

		[SerializeField]
		private double fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredDouble(long dummy)
		{
			currentCryptoKey = 0L;
			hiddenValue = default(ACTkByte8);
			hiddenValueOld = null;
			fakeValue = 0.0;
			inited = false;
		}

		public static void SetNewCryptoKey(long newKey)
		{
			cryptoKey = newKey;
		}

		public static long Encrypt(double value)
		{
			return Encrypt(value, cryptoKey);
		}

		public static long Encrypt(double value, long key)
		{
			return BitConverter.DoubleToInt64Bits(value) ^ key;
		}

		private static ACTkByte8 InternalEncrypt(double value)
		{
			return default(ACTkByte8);
		}

		private static ACTkByte8 InternalEncrypt(double value, long key)
		{
			return default(ACTkByte8);
		}

		public static double Decrypt(long value)
		{
			return Decrypt(value, cryptoKey);
		}

		public static double Decrypt(long value, long key)
		{
			return BitConverter.Int64BitsToDouble(value ^ key);
		}

		public void ApplyNewCryptoKey()
		{
			if (inited)
			{
				double decrypted = InternalDecrypt();
				currentCryptoKey = cryptoKey;
				SetEncrypted(Encrypt(decrypted, currentCryptoKey));
			}
		}

		public void RandomizeCryptoKey()
		{
			SetNewCryptoKey(((long)UnityEngine.Random.Range(int.MinValue, int.MaxValue) << 32) | (uint)UnityEngine.Random.Range(int.MinValue, int.MaxValue));
			ApplyNewCryptoKey();
		}

		public long GetEncrypted()
		{
			byte[] bytes = new byte[8] { hiddenValue.b1, hiddenValue.b2, hiddenValue.b3, hiddenValue.b4, hiddenValue.b5, hiddenValue.b6, hiddenValue.b7, hiddenValue.b8 };
			return BitConverter.ToInt64(bytes, 0);
		}

		public void SetEncrypted(long encrypted)
		{
			currentCryptoKey = cryptoKey;
			byte[] bytes = BitConverter.GetBytes(encrypted);
			hiddenValue = new ACTkByte8 { b1 = bytes[0], b2 = bytes[1], b3 = bytes[2], b4 = bytes[3], b5 = bytes[4], b6 = bytes[5], b7 = bytes[6], b8 = bytes[7] };
			inited = true;
			fakeValue = InternalDecrypt();
		}

		public double GetDecrypted()
		{
			return InternalDecrypt();
		}

		private double InternalDecrypt()
		{
			if (!inited)
			{
				return 0.0;
			}
			return Decrypt(GetEncrypted(), currentCryptoKey);
		}

		public static implicit operator ObscuredDouble(double value)
		{
			ObscuredDouble result = default(ObscuredDouble);
			result.SetEncrypted(Encrypt(value, cryptoKey));
			return result;
		}

		public static implicit operator double(ObscuredDouble value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return (double)input + 1.0;
		}

		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return (double)input - 1.0;
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

		public override bool Equals(object obj)
		{
			return obj is ObscuredDouble other && Equals(other);
		}

		public bool Equals(ObscuredDouble obj)
		{
			return InternalDecrypt().Equals(obj.InternalDecrypt());
		}

		public override int GetHashCode()
		{
			return InternalDecrypt().GetHashCode();
		}
	}
}
