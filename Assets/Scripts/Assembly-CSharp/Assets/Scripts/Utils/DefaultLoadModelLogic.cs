using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class DefaultLoadModelLogic : LoadModelLogic
	{
		private GameObject uiModelContainer;

		public DefaultLoadModelLogic(GameObject uiModelContainer)
		{
		}

		public void Prepare()
		{
		}

		public void AnchorUIAndModelPosition(GameObject model)
		{
		}

		public void ModifyInfoAfterInstantiate(GameObject model)
		{
		}

		public GameObject ModelRoot()
		{
			return null;
		}

		public bool Instantly()
		{
			return false;
		}

		public string GetCharacterPrefabPath(int groupId, int subId)
		{
			return null;
		}
	}
}
