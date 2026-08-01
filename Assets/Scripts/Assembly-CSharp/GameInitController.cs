using System;
using Assets.Scripts.Ssar.Main;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInitController : MonoBehaviour
{
	public GameObject gameInitPrefab;

	public static GameInitController instance;

	private bool hasInit;

	private Action onInitFinish;

	private void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(gameObject);
			return;
		}

		instance = this;
		DontDestroyOnLoad(gameObject);
		gameObject.AddComponent<MainSceneBootstrap>();
		gameObject.AddComponent<ZonMobSplash>().Show(delegate { Init(FinishInit); });
	}

	// gameInitPrefab (Resources/guiprefabs/GameInit.prefab) holds the
	// persistent manager singletons: EntryContext (StrangeIoC boot context),
	// UnityMainThreadDispatcher, Localization, ad/analytics SDK glue
	// (AdController/AppsFlyerController/SDKManager - left as inert stubs,
	// not reconnected to real ad networks), and debug tools
	// (Reporter/HUDFPS/DebugLogOptions).
	public void Init(Action finish)
	{
		onInitFinish = finish;

		if (hasInit)
		{
			finish?.Invoke();
			return;
		}

		hasInit = true;

		if (gameInitPrefab != null)
		{
			GameObject instanceGo = Instantiate(gameInitPrefab, transform);
			instanceGo.name = gameInitPrefab.name;
		}

		finish?.Invoke();
	}

	public void FinishInit()
	{
		onInitFinish = null;

#if UNITY_EDITOR
		if (Input.GetKey(KeyCode.LeftShift))
		{
			GoToDevScene();
			return;
		}
#endif
		LoadSceneStart();
	}

	// Real game likely uses this to skip Title and jump straight into
	// Loading -> Main for players with a cached login session (persisted
	// Firebase auth between launches). No persisted-auth system is
	// reimplemented here, so this always routes through Title first -
	// LoadingScene's real place in the flow is between Title (after
	// login) and Main, not between Entry and Title (confirmed by
	// CheckAndLoadMainSceneCmd's asset-preload list: main character
	// model, daily-login/equipment/skill popups - all Main-scene
	// concerns, not Title-scene ones).
	private void LoadSceneStart()
	{
		GoToTitleScene();
	}

	private void GoToDevScene()
	{
		SceneManager.LoadScene("DevScene");
	}

	// Changed from private (decompiled signature) to public: LoadingSceneView
	// calls this once its progress/countdown sequence finishes, since
	// GameInitController is the persistent (DontDestroyOnLoad) singleton and
	// LoadingSceneView is recreated fresh each time LoadingScene loads.
	public void GoToTitleScene()
	{
		SceneManager.LoadScene("TitleScene");
	}
}
