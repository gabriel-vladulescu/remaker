using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.WorldMap.View
{
	public class CurrentDifficultyView : MonoBehaviour
	{
		public ScenarioDifficulty Difficulty;

		private DifficultySelectionView[] difficultySelectionViews;

		private bool isShow;

		public event Action<ScenarioDifficulty> OnDifficultySelected;

		private void Awake()
		{
			InitDifficulty();
		}

		private void OnEnable()
		{
			foreach (DifficultySelectionView view in difficultySelectionViews)
			{
				view.UpdateCurSelect(Difficulty);
			}
		}

		public void Init(ScenarioDifficulty scenarioDifficulty)
		{
			Difficulty = scenarioDifficulty;
			foreach (DifficultySelectionView view in difficultySelectionViews)
			{
				view.UpdateCurSelect(Difficulty);
			}
		}

		private void Select(ScenarioDifficulty difficulty, bool isInit)
		{
			Difficulty = difficulty;
			foreach (DifficultySelectionView view in difficultySelectionViews)
			{
				view.UpdateCurSelect(Difficulty);
			}
			if (!isInit)
			{
				OnDifficultySelected?.Invoke(difficulty);
			}
		}

		private void Select(ScenarioDifficulty difficulty)
		{
			Select(difficulty, isInit: false);
		}

		private void Hide()
		{
			gameObject.SetActive(false);
		}

		private void InitDifficulty()
		{
			difficultySelectionViews = GetComponentsInChildren<DifficultySelectionView>(includeInactive: true);
			foreach (DifficultySelectionView view in difficultySelectionViews)
			{
				view.onSelect += Select;
			}
		}
	}
}
