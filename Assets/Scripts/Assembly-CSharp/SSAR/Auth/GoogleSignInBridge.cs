using UnityEngine;

namespace Ssar.Auth
{
	public class GoogleSignInBridge : MonoBehaviour
	{
		private const string BridgeGameObjectName = "GoogleSignInBridge";

		private static GoogleSignInBridge _instance;

		public static GoogleSignInBridge Instance => null;

		public bool IsPending { get; private set; }

		public string IdToken { get; private set; }

		public string Error { get; private set; }

		public void Launch(string webClientId)
		{
		}

		private void OnSignInSuccess(string idToken)
		{
		}

		private void OnSignInFailure(string error)
		{
		}
	}
}
