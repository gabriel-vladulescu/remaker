using UnityEngine;

namespace Assets.Scripts.Utils
{
	public class LoadingSceneLoadModelLogic : LoadModelLogic
	{
		private readonly GameObject _uiRoot;

		private readonly GameObject _root3D;

		public LoadingSceneLoadModelLogic(GameObject UiRoot, GameObject root3d)
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
