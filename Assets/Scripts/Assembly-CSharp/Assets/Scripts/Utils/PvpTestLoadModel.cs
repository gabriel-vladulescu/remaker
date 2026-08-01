using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class PvpTestLoadModel : LoadModelLogic
	{
		private readonly GameObject _uiRoot;

		public PvpTestLoadModel(GameObject uiRoot)
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
