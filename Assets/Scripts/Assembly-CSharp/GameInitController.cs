using System;
using UnityEngine;

public class GameInitController : MonoBehaviour
{
	public GameObject gameInitPrefab;

	public static GameInitController instance;

	private bool hasInit;

	private Action onInitFinish;

	private void Awake()
	{
	}

	public void Init(Action finish)
	{
	}

	public void FinishInit()
	{
	}

	private void LoadSceneStart()
	{
	}

	private void GoToDevScene()
	{
	}

	private void GoToTitleScene()
	{
	}
}
