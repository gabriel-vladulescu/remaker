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
		if (btn_click != null)
		{
			UIEventListener.Get(btn_click).onClick += Select;
		}
		if (lb_text != null)
		{
			lb_text.text = Difficulty.ToString();
		}
	}

	public void UpdateCurSelect(ScenarioDifficulty curSelect)
	{
		bool isSelected = Difficulty == curSelect;
		if (sp_bg != null)
		{
			sp_bg.color = isSelected ? Color.white : new Color(0.6f, 0.6f, 0.6f);
		}
		if (btn_mask != null)
		{
			NGUITools.SetActive(btn_mask, isSelected);
		}
	}

	private void Select(GameObject o)
	{
		Select(Difficulty);
	}

	private void Select(ScenarioDifficulty difficulty)
	{
		if (!disable)
		{
			onSelect?.Invoke(difficulty);
		}
	}
}
