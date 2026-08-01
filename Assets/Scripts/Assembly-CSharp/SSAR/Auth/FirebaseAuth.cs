using System;
using Firebase.Auth;
using UnityEngine;

namespace Ssar.Auth
{
	public class FirebaseAuth
	{
		private const string GoogleAuthLogTag = "[FirebaseGoogleAuth]";

		private static Firebase.Auth.FirebaseAuth firebaseAuth;

		public static void SetAuth(Firebase.Auth.FirebaseAuth auth)
		{
		}

		public void LoginWithFacebook(string facebookToken, Action<bool, string, FirebaseUser> callback)
		{
		}

		public void LoginWithGoogle(string googleToken, Action<bool, string, FirebaseUser> callback)
		{
		}

		public void LoginWithGameCenter(string email, string password, Action<bool, string, FirebaseUser> callback)
		{
		}

		public void LoginAnonymously(Action<bool, string, FirebaseUser> callback)
		{
		}

		public void Logout()
		{
		}

		public bool IsLoggedIn()
		{
			return false;
		}

		public ProviderId ShowProviderId()
		{
			return default(ProviderId);
		}

		public string ShowUserId()
		{
			return null;
		}

		private bool IsAuthAvailable()
		{
			return false;
		}

		public void CreateFirebaseAccount(string email, string password, Action<bool, string> callback)
		{
		}

		public void LoginWithEmail(string email, string passWord, Action<bool, string, FirebaseUser> callback)
		{
		}

		public static AuthError GetErrorMessage(Exception exception)
		{
			return default(AuthError);
		}

		public void LinkToFacebook(string facebookToken, Action<bool, string> callBack)
		{
		}

		public void LinkToGoogle(string googleToken, Action<bool, string> callBack)
		{
		}

		private Credential CreateGoogleCredential(string token)
		{
			return null;
		}

		private void LogGoogleInvalidCredentialHints(string token)
		{
		}

		private void LogGoogleSignInAttemptContext(string token)
		{
		}

		private void LogGoogleRuntimeDebugContext()
		{
		}

		private void LogFirebaseAppOptions()
		{
		}

		private void LogTaskExceptionDetails(AggregateException aggregateException)
		{
		}

		private string GetTokenSummary(string token)
		{
			return null;
		}

		private string ComputeSha1Hex(string value)
		{
			return null;
		}

		private string ComputeSha256Hex(byte[] bytes)
		{
			return null;
		}

		private string BytesToHex(byte[] bytes)
		{
			return null;
		}

		private string SafeString(object value)
		{
			return null;
		}

		private string GetGameInfoApplicationId()
		{
			return null;
		}

		private string GetGameInfoWebClientId()
		{
			return null;
		}

		private string GetAndroidPackageName()
		{
			return null;
		}

		private string GetAndroidInstallerPackageName()
		{
			return null;
		}

		private string IsGoogleSocialUserAuthenticated()
		{
			return null;
		}

		private string GetAndroidDefaultWebClientId()
		{
			return null;
		}

		private string GetAndroidSigningSha1()
		{
			return null;
		}

		private string GetAndroidSigningSha256()
		{
			return null;
		}

		private byte[] GetPrimarySignatureBytes(AndroidJavaObject packageManager, string packageName)
		{
			return null;
		}

		private void LinkAccount(Credential credential, Action<bool, string> callBack)
		{
		}
	}
}
