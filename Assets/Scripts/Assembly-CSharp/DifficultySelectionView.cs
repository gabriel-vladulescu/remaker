using System;
using UnityEngine;

public class DifficultySelectionView : MonoBehaviour
{
	public UILabel lb_text;

	public UISprite sp_bg;

	public ScenarioDifficulty Difficulty;

	public GameObject btn_click;

	public GameObject btn_mask;

	public bool disable;

	public Action<ScenarioDifficulty> onSelect;

	private void Awake()
	{
	}

	public void UpdateCurSelect(ScenarioDifficulty curSelect)
	{
	}

	private void Select(GameObject o)
	{
	}

	private void Select(ScenarioDifficulty difficulty)
	{
	}
}
