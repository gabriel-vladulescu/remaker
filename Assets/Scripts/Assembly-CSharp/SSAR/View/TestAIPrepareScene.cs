using Assets.Scripts.Ssar.CharacterSelection.Model;
using UnityEngine;

namespace SSAR.View
{
	public class TestAIPrepareScene : MonoBehaviour
	{
		public GameObject btn_back;

		public GameObject btn_adventure;

		public GameObject btn_bloody;

		public GameObject btn_Normal;

		public GameObject btn_Hard;

		public GameObject btn_Hell;

		public GameObject btn_Insane;

		public GameObject btnLevel;

		public UIPopupList popupCharacter;

		public UILabel labelCharacter;

		private void Awake()
		{
		}

		private CharacterCode GetCharacterCode()
		{
			return default(CharacterCode);
		}
	}
}
