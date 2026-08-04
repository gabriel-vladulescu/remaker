using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredFloat : IEquatable<ObscuredFloat>, IFormattable
	{
		[StructLayout((LayoutKind)2)]
		private struct FloatIntBytesUnion
		{
			[FieldOffset(0)]
			public float f;

			[FieldOffset(0)]
			public int i;

			[FieldOffset(0)]
			public ACTkByte4 b4;
		}

		private static int cryptoKey;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private ACTkByte4 hiddenValue;

		[SerializeField]
		[FormerlySerializedAs("hiddenValue")]
		private byte[] hiddenValueOld;

		[SerializeField]
		private float fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredFloat(int dummy)
		{
			currentCryptoKey = 0;
			hiddenValue = default(ACTkByte4);
			hiddenValueOld = null;
			fakeValue = 0f;
			inited = false;
		}

		public static void SetNewCryptoKey(int newKey)
		{
			cryptoKey = newKey;
		}

		public static int Encrypt(float value)
		{
			return Encrypt(value, cryptoKey);
		}

		public static int Encrypt(float value, int key)
		{
			return BitConverter.ToInt32(BitConverter.GetBytes(value), 0) ^ key;
		}

		private static ACTkByte4 InternalEncrypt(float value)
		{
			return default(ACTkByte4);
		}

		private static ACTkByte4 InternalEncrypt(float value, int key)
		{
			return default(ACTkByte4);
		}

		public static float Decrypt(int value)
		{
			return Decrypt(value, cryptoKey);
		}

		public static float Decrypt(int value, int key)
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(value ^ key), 0);
		}

		public void ApplyNewCryptoKey()
		{
			if (inited)
			{
				float decrypted = InternalDecrypt();
				currentCryptoKey = cryptoKey;
				SetEncrypted(Encrypt(decrypted, currentCryptoKey));
			}
		}

		public void RandomizeCryptoKey()
		{
			SetNewCryptoKey(UnityEngine.Random.Range(int.MinValue, int.MaxValue));
			ApplyNewCryptoKey();
		}

		public int GetEncrypted()
		{
			return BitConverter.ToInt32(new byte[] { hiddenValue.b1, hiddenValue.b2, hiddenValue.b3, hiddenValue.b4 }, 0);
		}

		public void SetEncrypted(int encrypted)
		{
			currentCryptoKey = cryptoKey;
			byte[] bytes = BitConverter.GetBytes(encrypted);
			hiddenValue = new ACTkByte4 { b1 = bytes[0], b2 = bytes[1], b3 = bytes[2], b4 = bytes[3] };
			inited = true;
			fakeValue = InternalDecrypt();
		}

		public float GetDecrypted()
		{
			return InternalDecrypt();
		}

		private float InternalDecrypt()
		{
			if (!inited)
			{
				return 0f;
			}
			return Decrypt(GetEncrypted(), currentCryptoKey);
		}

		public static implicit operator ObscuredFloat(float value)
		{
			ObscuredFloat result = default(ObscuredFloat);
			result.SetEncrypted(Encrypt(value, cryptoKey));
			return result;
		}

		public static implicit operator float(ObscuredFloat value)
		{
			return value.InternalDecrypt();
		}

		public static ObscuredFloat operator ++(ObscuredFloat input)
		{
			return (float)input + 1f;
		}

		public static ObscuredFloat operator --(ObscuredFloat input)
		{
			return (float)input - 1f;
		}

		public override bool Equals(object obj)
		{
			return obj is ObscuredFloat other && Equals(other);
		}

		public bool Equals(ObscuredFloat obj)
		{
			return InternalDecrypt().Equals(obj.InternalDecrypt());
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
