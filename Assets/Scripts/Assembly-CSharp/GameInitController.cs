using System;
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
		Init(FinishInit);
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

	private void LoadSceneStart()
	{
		SceneManager.LoadScene("LoadingScene");
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
