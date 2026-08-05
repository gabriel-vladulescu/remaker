using Assets.Scripts.Ssar.Dungeon;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace SSAR.View
{
	public class UserDataView : strange.extensions.mediation.impl.View
	{
		public UILabel lb_lv;

		public UILabel lb_name;

		public UILabel lb_expPercent;

		public UIProgressBar ProgressBar;

		// No real save/economy system exists (MainCharacterData is stub,
		// no persisted player data) - shows the same known-good default
		// character CharacterSelectionPopup/DungeonSelection already use,
		// at 0% exp, rather than fabricating a leveled-up save file.
		public void Show()
		{
			gameObject.SetActive(true);
			UpdateDisplayName();
			UpdateData(0);
		}

		public void UpdateDisplayName()
		{
			if (lb_name != null)
			{
				lb_name.text = "Hero";
			}
			if (lb_lv != null)
			{
				lb_lv.text = "Lv." + DungeonSelection.HeroLevel;
			}
		}

		public void UpdateData(int exp)
		{
			const int expForNextLevel = 100;
			int percent = Mathf.Clamp(Mathf.RoundToInt(exp / (float)expForNextLevel * 100f), 0, 100);
			if (lb_expPercent != null)
			{
				lb_expPercent.text = percent + "%";
			}
			if (ProgressBar != null)
			{
				ProgressBar.value = percent / 100f;
			}
		}

		public void Hide()
		{
			gameObject.SetActive(false);
		}
	}
}
