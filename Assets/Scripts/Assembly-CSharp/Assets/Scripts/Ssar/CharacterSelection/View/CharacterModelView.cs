using System;
using Assets.Scripts.Utils;
using UnityEngine;

namespace Assets.Scripts.Ssar.CharacterSelection.View
{
	public class CharacterModelView : MonoBehaviour
	{
		public GameObject modelRoot;

		private void Awake()
		{
		}

		public void UpdateModel(MainCharacterData mainCharacterData, bool isNewCharCreate)
		{
		}

		public void UpdateModel(int groupId, int subId, DisplayCharacterInfo displayCharacterInfo, bool isNewCharCreate, Action<LoadModelLogic, GameObject> callback = null)
		{
		}
	}
}
