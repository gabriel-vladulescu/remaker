using System.Collections.Generic;
using Assets.Scripts.Ssar.CharacterSelection.Model;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Ssar.CharacterSelection.View
{
	public class CreateCharacterWidget : MonoBehaviour
	{
		public enum CharacterCreationSource
		{
			Free = 0,
			LevelRequired = 1,
			Paid = 2
		}

		public GameObject btn_crateCharacter;

		public GameObject btn_random;

		public GameObject wg_sell;

		public GameObject wg_createByLevel;

		public GameObject btn_buy;

		public GameObject btn_createByLevel;

		public UITable table_buyExtra;

		public UILabel lb_sellPrice;

		public UILabel lb_createCharacter;

		public UILabel lb_buyByLevelRequire;

		public GameObject btnTry;

		public Color colorInvalid;

		public Color colorValid;

		private List<RandomDisplayFirstNameValue> firstNames;

		private CharacterCode character;

		private CharacterSelectionElementInfo elementInfo;

		private void Awake()
		{
		}

		public void Show(CharacterCode tabType)
		{
		}

		public void Hide()
		{
		}

		private void RandomName(GameObject o)
		{
		}

		private void Create(GameObject o, CharacterCreationSource source)
		{
		}

		private void Buy(GameObject o)
		{
		}

		private void CreateBylevel(GameObject o)
		{
		}

		private bool IsValidLevel()
		{
			return false;
		}

		private void Try(GameObject o)
		{
		}
	}
}
