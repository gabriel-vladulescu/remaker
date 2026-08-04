using System;
using UnityEngine;

namespace Assets.Scripts.Ssar.CharacterSelection.View
{
	public class SelectCharacterWidget : MonoBehaviour
	{
		public GameObject btn_start;

		public UILabel lb_name;

		public GameObject btn_delete;

		private MainCharacterData mainCharacterData;

		// Deviation from the original stub: the real multi-character roster
		// (create/select/delete backed by MainCharacterData + BayatGames
		// SaveGameFree) is a large, not-yet-reimplemented subsystem - see
		// CharacterSelectionPopup. This callback is how the simplified
		// single-character flow tells CharacterSelectionPopup "the player
		// wants to proceed" without needing that roster.
		public event Action<MainCharacterData> OnStart;

		private void Awake()
		{
			if (btn_start != null)
			{
				UIEventListener.Get(btn_start).onClick += Select;
			}
			if (btn_delete != null)
			{
				btn_delete.SetActive(false);
			}
		}

		private void Delete(GameObject go)
		{
		}

		public void Show(MainCharacterData mainCharacterData)
		{
			this.mainCharacterData = mainCharacterData;
			if (lb_name != null)
			{
				lb_name.text = mainCharacterData?.displayName;
			}
			gameObject.SetActive(true);
		}

		public void Hide()
		{
			gameObject.SetActive(false);
		}

		private void Select(GameObject o)
		{
			OnStart?.Invoke(mainCharacterData);
		}
	}
}
