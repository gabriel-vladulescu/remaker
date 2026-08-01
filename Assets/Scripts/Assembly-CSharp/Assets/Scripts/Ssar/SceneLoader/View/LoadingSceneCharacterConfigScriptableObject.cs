using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ssar.SceneLoader.View
{
	[Serializable]
	[CreateAssetMenu(menuName = "ScriptableOject/LoadingScene")]
	public class LoadingSceneCharacterConfigScriptableObject : ScriptableObject
	{
		public List<LoadingSceneCharacterConfig> CharacterConfigs;

		public List<LoadingSceneChacterSetEquipment> sets;

		public void Init()
		{
		}

		public LoadingSceneCharacterConfig GetCharacterConfig(int groupId)
		{
			return null;
		}
	}
}
