using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Firestore;
using GooglePlayGames.BasicApi;
using SSAR.Entry.Model;
using Ssar.Auth;
using Ssar.Database;
using UnityEngine;

namespace Assets.Scripts.Ssar.DataManager
{
	public class FirebaseCloudDataController
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public SignInStatus? status;

			public FirebaseCloudDataController _003C_003E4__this;

			public Action<string> success;

			public Action<string> error;

			internal void _003CLoginGoogleRoutine_003Eb__0(SignInStatus result)
			{
			}

			internal void _003CLoginGoogleRoutine_003Eb__1(bool ok, string tokenValue)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass25_1
		{
			public SignInStatus? manualStatus;

			internal void _003CLoginGoogleRoutine_003Eb__2(SignInStatus result)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetGameCenterToken_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CGetGameCenterToken_003Ed__34(int _003C_003E1__state)
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
		private sealed class _003CGetGoogleServerAuthCode_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action<bool, string> callBack;

			private AndroidJavaObject _003CsignInTask_003E5__2;

			private float _003CsilentTimeout_003E5__3;

			private float _003CsilentElapsed_003E5__4;

			private GoogleSignInBridge _003Cbridge_003E5__5;

			private float _003CinteractiveTimeout_003E5__6;

			private float _003CinteractiveElapsed_003E5__7;

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
			public _003CGetGoogleServerAuthCode_003Ed__32(int _003C_003E1__state)
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
		private sealed class _003CLoginGoogleRoutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FirebaseCloudDataController _003C_003E4__this;

			public Action<string> success;

			public Action<string> error;

			private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

			private _003C_003Ec__DisplayClass25_1 _003C_003E8__2;

			private float _003Ctimeout_003E5__2;

			private float _003Celapsed_003E5__3;

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
			public _003CLoginGoogleRoutine_003Ed__25(int _003C_003E1__state)
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

		private FirebaseUserDataSavingOperation saveOperation;

		private FirebaseUserDataDeletingOperation deletingOperation;

		private FirebaseUserDataLoadingOperation loadingOperation;

		private global::Ssar.Auth.FirebaseAuth firebaseAuth;

		private FirebaseUser firebaseUser;

		private FirebaseFirestore firebaseFirestore;

		private FirebaseDatabase firebaseDatabase;

		private bool googleAuthInProgress;

		private bool hasInitGameCenter;

		public FirebaseCloudDataController(FirebaseFirestore firebaseFirestore, FirebaseDatabase firebaseDatabase)
		{
		}

		public virtual void SaveToCloud(FirebaseUser user, UserData localData, Action<bool, string> callBack = null)
		{
		}

		public virtual void SaveToCloud(FirebaseUser user, string path, int value, Action<bool, string> callBack = null)
		{
		}

		public virtual void GetFirebaseFacebookData(Action<string, UserData> callBack)
		{
		}

		public virtual void LoginWithEmail(string email, string password, Action<string, UserData> callBack)
		{
		}

		public virtual void GetFirebaseDataWithFacebook(Action<string, UserData> callBack, string facebookToken)
		{
		}

		public virtual void GetFirebaseDataWithGoogle(Action<string, UserData> callBack, string googleToken)
		{
		}

		public virtual void GetFirebaseDataWithEmail(string email, string password, Action<string, UserData> callBack)
		{
		}

		public virtual void GetFirebaseDataWithGameCenter(Action<string, UserData> callBack, string email, string password)
		{
		}

		public virtual void LoadFromCloud(FirebaseUser user, Action<string, UserData> callBack)
		{
		}

		public void LoadFromDatabase(FirebaseUser user, Action<string, UserData> callBack)
		{
		}

		public virtual void LoadFromCloud(FirebaseUser user, string path, Action<bool, string, ErrorCode, int> callBack = null)
		{
		}

		public virtual void LinkToFacebook(UserData localData, Action<bool, string> callBack)
		{
		}

		public virtual void LinkToGoogle(UserData localData, Action<bool, string> callBack)
		{
		}

		public virtual void LoginFacebook(Action success, Action<string> error)
		{
		}

		public virtual void LoginGoogle(Action<string> success, Action<string> error)
		{
		}

		[IteratorStateMachine(typeof(_003CLoginGoogleRoutine_003Ed__25))]
		private IEnumerator LoginGoogleRoutine(Action<string> success, Action<string> error)
		{
			return null;
		}

		public virtual void LoginGameCenter(Action<KeyValuePair<string, string>> success, Action<string> error)
		{
		}

		public virtual FirebaseUser GetFirebaseUser()
		{
			return null;
		}

		public virtual bool HasLoginFirebase()
		{
			return false;
		}

		public virtual string GetFirebaseUserId()
		{
			return null;
		}

		public string GuestLoginEmail()
		{
			return null;
		}

		public string GuestLoginPassword()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetGoogleServerAuthCode_003Ed__32))]
		private IEnumerator GetGoogleServerAuthCode(Action<bool, string> callBack)
		{
			return null;
		}

		private void InitGameCenter()
		{
		}

		[IteratorStateMachine(typeof(_003CGetGameCenterToken_003Ed__34))]
		private IEnumerator GetGameCenterToken(Action<bool, KeyValuePair<string, string>> callBack)
		{
			return null;
		}

		public void SignOut()
		{
		}

		private AbsLogin GetLoginMode(UserData userData)
		{
			return null;
		}
	}
}
