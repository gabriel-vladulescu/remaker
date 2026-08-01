using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using BayatGames.SaveGameFree.Encoders;
using BayatGames.SaveGameFree.Serializers;
using UnityEngine.Networking;

namespace BayatGames.SaveGameFree
{
	public class SaveGameWeb
	{
		[CompilerGenerated]
		private sealed class _003CDownload_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SaveGameWeb _003C_003E4__this;

			public string identifier;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDownload_003Ed__83(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSave_003Ed__82<T> : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SaveGameWeb _003C_003E4__this;

			public T obj;

			public string identifier;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSave_003Ed__82(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSend_003Ed__86 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string identifier;

			public string action;

			public SaveGameWeb _003C_003E4__this;

			public string data;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSend_003Ed__86(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private static string m_DefaultUsername;

		private static string m_DefaultPassword;

		private static string m_DefaultURL;

		private static bool m_DefaultEncode;

		private static string m_DefaultEncodePassword;

		private static ISaveGameSerializer m_DefaultSerializer;

		private static ISaveGameEncoder m_DefaultEncoder;

		private static Encoding m_DefaultEncoding;

		protected string m_Username;

		protected string m_Password;

		protected string m_URL;

		protected bool m_Encode;

		protected string m_EncodePassword;

		protected ISaveGameSerializer m_Serializer;

		protected ISaveGameEncoder m_Encoder;

		protected Encoding m_Encoding;

		protected UnityWebRequest m_Request;

		protected bool m_IsError;

		protected string m_Error;

		public static string DefaultUsername
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string DefaultPassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string DefaultURL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool DefaultEncode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static string DefaultEncodePassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static ISaveGameSerializer DefaultSerializer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static ISaveGameEncoder DefaultEncoder
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

		public virtual string Username
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Password
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string URL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool Encode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual string EncodePassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual ISaveGameSerializer Serializer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual ISaveGameEncoder Encoder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Encoding Encoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual UnityWebRequest Request => null;

		public virtual bool IsError => false;

		public virtual string Error => null;

		public SaveGameWeb()
		{
		}

		public SaveGameWeb(string username)
		{
		}

		public SaveGameWeb(string username, string password)
		{
		}

		public SaveGameWeb(string username, string password, string url)
		{
		}

		public SaveGameWeb(string username, string password, string url, bool encode)
		{
		}

		public SaveGameWeb(string username, string password, string url, bool encode, string encodePassword)
		{
		}

		public SaveGameWeb(string username, string password, string url, bool encode, string encodePassword, ISaveGameSerializer serializer)
		{
		}

		public SaveGameWeb(string username, string password, string url, bool encode, string encodePassword, ISaveGameSerializer serializer, ISaveGameEncoder encoder)
		{
		}

		public SaveGameWeb(string username, string password, string url, bool encode, string encodePassword, ISaveGameSerializer serializer, ISaveGameEncoder encoder, Encoding encoding)
		{
		}

		[IteratorStateMachine(typeof(_003CSave_003Ed__82<>))]
		public virtual IEnumerator Save<T>(string identifier, T obj)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDownload_003Ed__83))]
		public virtual IEnumerator Download(string identifier)
		{
			return null;
		}

		public virtual T Load<T>(string identifier)
		{
			return default(T);
		}

		public virtual T Load<T>(string identifier, T defaultValue)
		{
			return default(T);
		}

		[IteratorStateMachine(typeof(_003CSend_003Ed__86))]
		public virtual IEnumerator Send(string identifier, string data, string action)
		{
			return null;
		}
	}
}
